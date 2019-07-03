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
using FrameworkSolution.ObjectRepository;
using FrameworkSolution.Functions.GeneralFunction;

namespace FrameworkSolution.Functions.ApplicationFunction
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class ImageComparison : Obj_ImageComparison
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        [UserCodeMethod]
        public void Img_Comp()
        {
        	
        	Obj_ImageComparison obj6 = new Obj_ImageComparison();
        	Delay.Seconds(3);
        	
        	Point NewButton = new Point(29,86);
			Mouse.MoveTo(NewButton);
			
			Mouse.Click(obj6.Driver.BarButtonItemLinkNewButtonItem);
			Delay.Seconds(2);
        	
        	
        	
        	//Calling CurrentImage from Object Repository...
        	Bitmap CaptureImage = Imaging.CaptureImage("/form[@name='Create New Estimate' and @visible='True']");
        	//Calling image from Base Location
        	Bitmap BaseImage = Imaging.Load(@"C:\Users\Test\Documents\Ranorex\Snapshots\CreateNewEstimate_Screenshot55.bmp");
            
        	//calling image comparison function from base class
        	BaseClass B = new BaseClass(); 
        	B.Image_Comparison(CaptureImage,BaseImage);
        	
        	
        	Mouse.Click(obj6.CreateNewEstimate.PARTCloseButton);
        	Delay.Seconds(2);
        	
        }
    }
}
