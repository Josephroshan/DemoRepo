/*
 * Created by Ranorex
 * User: Test
 * Date: 6/12/2019
 * Time: 5:09 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using FrameworkSolution.DemoObj__Repo;
using FrameworkSolution.ObjectRepository;
using FrameworkSolution.Functions.GeneralFunction;

namespace FrameworkSolution.Functions.ApplicationFunction
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class ImageComparison : CreateEstimate
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        [UserCodeMethod]
        public void Img_Comp()
        {
        	
        	CreateEstimate obj3 = new CreateEstimate();
        	Delay.Seconds(2);
        	
        	//Point NewButton = new Point(29,86);
			//Mouse.MoveTo(NewButton);
			
			//Mouse.Click(obj6.Driver.HomeScreen);
			//Delay.Seconds(2);
        	
        	
        	
        	//Calling CurrentImage from Object Repository...
        	Bitmap CaptureImage = Imaging.CaptureImage("/form[@automationid='Driver']/?/?/element[@automationid='m_RibbonControl']/container[@automationid='PART_AutoHideControl']/container[@automationid='PART_DefaultRibbon']/container[@automationid='PART_MainLayout']/container[@automationid='PART_SelectedPage']/container[@automationid='PART_SelectedPageControlContainer']/list/container[@automationid='root']//container[@automationid='PART_ScrollViewer']/?/?/container[@automationid='PART_ItemsPresenter']/?/?/list/container[@caption='']/container[@caption='']/list/?/?/container/list[1]/?/?/container[@automationid='PART_Border']/?/?/container[@automationid='PART_ItemsPresenter']//button[@text='New' and @visible='True']");
        		Bitmap BaseImage = Imaging.Load(@"C:\Users\THI1901453\Desktop\FrameworkSolution\FrameworkSolution\createEs_1.jpg");
            
        	//calling image comparison function from base class
        	BaseClass B = new BaseClass(); 
        	B.Image_Comparison(BaseImage,CaptureImage);
        	
        	
        	Mouse.Click(obj3.Driver.PARTCloseButton);
        	Delay.Seconds(2);
        	
        }
    }
}
