/*
 * Created by Ranorex
 * User: Test
 * Date: 6/12/2019
 * Time: 2:04 PM
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

namespace FrameworkSolution.Functions.ApplicationFunction
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class AddLineItem : Obj_AddLineItem_EstimateView
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        [UserCodeMethod]
        public void Add_LineItem()
        {
        	Obj_AddLineItem_EstimateView obj5 = new Obj_AddLineItem_EstimateView();
        	//Delay.Seconds(5);
        	
        	//obj5.Driver.BarItemLinkAddLineItemButtonCL001AddLineInfo.WaitForExists(20000); //waiting the object until visible
        	//Mouse.Click(obj5.Driver.BarItemLinkAddLineItemButtonCL001AddLine);
        	//Delay.Seconds(2);
        	
        	//Using Coordinate to select Assembly Line Item...
        	Point AdLineItm = new Point(102,96);
        	Mouse.MoveTo(AdLineItm);
        	Mouse.Click(AdLineItm);
			Delay.Seconds(4);
			
			
			//Try_Catch method used to check Collection Classification is visible or not...
        	try
        		{
        		
        		Mouse.DoubleClick(obj5.MCostComponentWindow.UnclassifiedItemsItemBECKControls); 
        		Delay.Seconds(4);
        			
        		}
        	
        	catch
        		{
        			//Mouse.Click(obj2.MCostComponentWindow.LayoutRoot.Image); 
        			Delay.Seconds(2);
        			
        			Mouse.Click(obj5.MCostComponentWindow.Image); 
        			Delay.Seconds(2);
        			Mouse.Click(obj5.MConfigureGroupingWindow.CollectionClassification);  
        			Delay.Seconds(2);
        			Mouse.Click(obj5.MConfigureGroupingWindow.Image);
        			Delay.Seconds(2);
        			Mouse.Click(obj5.MConfigureGroupingWindow.TextOK); 
        			Delay.Seconds(2);
        		
        		}
        	
        	//Delay.Seconds(2);
        	Mouse.Click(obj5.MCostComponentWindow.PARTMaximize);
			Delay.Seconds(3);
        	
			//Click in coordinates to select Add Assembly TakeOff...
        	Point AddLinItm = new Point(83,170);
			Mouse.MoveTo(AddLinItm);  
            Mouse.DoubleClick(AddLinItm);
            Delay.Seconds(4); 
        	
        	//Adding lineitem to Estimate...
        	Mouse.Click(obj5.MTakeoffWindow.TextAdd);
        	Delay.Seconds(2);
        	Mouse.Click(obj5.MTakeoffWindow.Close);
        	Delay.Seconds(2);
        	
        	//Closing MCostComponentWindow...
        	Mouse.Click(obj5.MCostComponentWindow.PARTCloseButton);
        	Delay.Seconds(1);
        	
        }
    }
}
