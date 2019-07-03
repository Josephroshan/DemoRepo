/*
 * Created by Ranorex
 * User: THI1901449
 * Date: 07/02/2019
 * Time: 16:49
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;
using DEstimator.Repository.EstimateView;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using DEstimator.Repository;

namespace DEstimator.Functions.GeneralFunction
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class GeneralFunction : object_Repository_CreateNewEstimate
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        [DllImport("User32")]
    	private static extern IntPtr SetForegroundWindow(IntPtr hWnd);
    	[DllImport("User32")]
    	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    	
    	
    	//----------------------------------
		//...***TO LAUNCH APPLICATION***...    
		//----------------------------------
    	[UserCodeMethod]
    	public void Applaunch()
    	{
        	
    		var process = new Process {
    		StartInfo = new ProcessStartInfo {
    			FileName = ConfigurationManager.AppSettings["AppLaunch"]
    			}
    		};
    		process.Start();
    		while(string.IsNullOrEmpty(process.MainWindowTitle))
    		{
    			
    			Delay.Seconds(5);
    			process.Refresh();
    		}
    	
    	IntPtr windowHandle;
    	windowHandle = process.MainWindowHandle;
    	
    	ShowWindow(windowHandle,3);
    	SetForegroundWindow(windowHandle);
    		
    	}
    	
		
    	//CREATE ESTIMATE
    	
		 public void Create_Estimate() 
				{
					object_Repository_CreateNewEstimate objCreateEst = new object_Repository_CreateNewEstimate();
					
					Point NewButton = new Point(29,86);
					Mouse.MoveTo(NewButton);
					objCreateEst.Driver.BarButtonItemLinkNewButtonItemInfo.WaitForExists(12000); 
					Mouse.Click(objCreateEst.Driver.BarButtonItemLinkNewButtonItem);
					
				    //objCreateEst.CreateNewEstimate.PARTContentHostInfo.WaitForExists(200);
					Mouse.Click(objCreateEst.CreateNewEstimate.PARTContentHost); //Giveing name to the Estimate
					Delay.Seconds(1);
					Random re = new Random();
					Keyboard.Press(objCreateEst.CreateNewEstimate.PARTContentHost, "j"+re.Next(1,15));
					Delay.Seconds(1);
					
					Mouse.Click(objCreateEst.CreateNewEstimate.CreateNewButton); 
					Delay.Seconds(5);
					
		    }	
		//-----------------------------------
    	//...***TO CLOSE APPLICATION***...  
    	//-----------------------------------
    	[UserCodeMethod]
    	public void AppClose()
    	{
    		
    		object_Repository_CreateNewEstimate objClose =  new object_Repository_CreateNewEstimate();
    		//object_Repository_CreateNewEstimate ObjClose = new object_Repository_CreateNewEstimate(); //Directly hit on ESTIMATOR close button in main window.
    		Mouse.Click(objClose.Driver.PARTCloseButton);
    	}
    	
    	
    	//------------------------------
    	//...***IMAGE COMPARISON***...
		//------------------------------
		/*[UserCodeMethod]
		public void Image_Comparison(Bitmap BaseImage,Bitmap CaptureImage )
		{
		
			if (Ranorex.Imaging.Compare(BaseImage, CaptureImage)==1) //Condition for checking base image and captured image.
                  
                 { 
                    Report.Success("Image Comparison is SUCCESS!!!");
                    Report.LogData (ReportLevel.Success, "Expected", BaseImage);  
                    Report.LogData (ReportLevel.Success, "Actual", CaptureImage);
                 }
                 
        	else
                 {
                    Report.Failure("Image Comparison is FAILED!!!");
                    Report.LogData (ReportLevel.Error, "Expected", BaseImage);  
                    Report.LogData (ReportLevel.Error, "Actual", CaptureImage);
                 }
			
		}*/
    	
    }
        
    }
