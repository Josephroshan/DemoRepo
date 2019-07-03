/*
 * Created by Ranorex
 * User: THI1903474
 * Date: 5/27/2019
 * Time: 1:03 PM
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
using FrameworkSolution;
using FrameworkSolution.ObjectRepository;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FrameworkSolution.Functions.GeneralFunction
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    
    [UserCodeCollection]
    public class BaseClass : Obj_GenaralClass
    {   	
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
        	//string Launch = ConfigurationManager.AppSettings["AppLaunch"]; //Method calling from app.config file.
    		//System.Diagnostics.Process.Start(Launch);
    		
    		//Mouse.MoveTo("/menubar[@processname='explorer']/container[@controlid='40965']//toolbar[@accessiblename='Running applications']/button[@accessiblename='DESTINI Estimator']");
    		
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
    	//Mouse.MoveTo("/menubar[@processname='explorer']/container[@controlid='40965']//toolbar[@accessiblename='Running applications']/button[@accessiblename='DESTINI Estimator']");
    	IntPtr windowHandle;
    	windowHandle = process.MainWindowHandle;
    	
    	ShowWindow(windowHandle,3);
    	SetForegroundWindow(windowHandle);
    		
    	}
    	
		
		//-----------------------------------
    	//...***TO CLOSE APPLICATION***...  
    	//-----------------------------------
    	[UserCodeMethod]
    	public void AppClose()
    	{
    		Obj_GenaralClass Obj1 = new Obj_GenaralClass(); //Directly hit on ESTIMATOR close button in main window.
    		Mouse.Click(Obj1.Driver.PARTCloseButton);
    	}
    	
    	
    	//------------------------------
    	//...***IMAGE COMPARISON***...
		//------------------------------
		[UserCodeMethod]
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
			
		}
    	
    }
}

