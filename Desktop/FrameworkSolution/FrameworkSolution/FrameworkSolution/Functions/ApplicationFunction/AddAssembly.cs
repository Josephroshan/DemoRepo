/*
 * Created by Ranorex
 * User: Test
 * Date: 6/10/2019
 * Time: 3:42 PM
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
    public class AddAssembly : Obj_AddAssembly_EstimateView
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        [UserCodeMethod]
        public void Add_Assemby()
        {
        	
        	Obj_AddAssembly_EstimateView obj2 = new Obj_AddAssembly_EstimateView();
        	//Delay.Seconds(6);
        	
        	//obj2.Driver.BarItemLinkAddAssemblyButtonCL001AddAsseInfo.WaitForExists(20000); //waiting the object until visible
			
        	Point AdAssmbly = new Point(36,104);
        	Mouse.MoveTo(AdAssmbly);
        	Mouse.Click(AdAssmbly);
			Delay.Seconds(3);
			
			
        	
        	try
        		{
        		
        		Mouse.DoubleClick(obj2.MCostComponentWindow.UnclassifiedItemsItemBECKControls); 
        		Delay.Seconds(2);
        			
        		}
        	
        	catch
        		{
        			//Mouse.Click(obj2.MCostComponentWindow.LayoutRoot.Image); 
        			Delay.Seconds(2);
        			
        			Mouse.Click(obj2.MConfigureGroupingWindow.CollectionClassification); 
        			Delay.Seconds(2);
        			Mouse.Click(obj2.MConfigureGroupingWindow.Image);  
        			Delay.Seconds(2);
        			Mouse.Click(obj2.MConfigureGroupingWindow.TextOK); 
        			Delay.Seconds(2);
        		
        		}
        	Delay.Seconds(2);
        	Mouse.Click(obj2.Driver.PARTMaximize);
			Delay.Seconds(2);
        	
			//Click in coordinates to select Add Assembly TakeOff...
        	Point AddAssmeblies = new Point(84,168);
			Mouse.MoveTo(AddAssmeblies);  
            Mouse.DoubleClick(AddAssmeblies);
            Delay.Seconds(3); 
        	
        	//Assembly Takeoff Window...
        	Mouse.Click(obj2.MTakeoffWindow.PARTContentHost); 
        	Delay.Seconds(2);
        	Keyboard.Press(obj2.MTakeoffWindow.PARTContentHost, "2");
        	Delay.Seconds(2);
        	
        	Mouse.Click(obj2.MTakeoffWindow.PARTItem); 
        	Delay.Seconds(2);
        	Mouse.Click(obj2.MTakeoffWindow.TextAdd); 
        	Delay.Seconds(2);
        	Mouse.Click(obj2.MTakeoffWindow.Close); 
        	Delay.Seconds(2);
        	
        	//Close Add Assemblies window...
        	Mouse.Click(obj2.MCostComponentWindow.PARTCloseButton); 
        	Delay.Seconds(1);
        	
        	
        }
        
		
        
		
        
    }
}
