/*
 * Created by Ranorex
 * User: Test
 * Date: 6/12/2019
 * Time: 2:47 PM
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
using FrameworkSolution.Functions.ApplicationFunction;
using FrameworkSolution.ObjectRepository;
using FrameworkSolution.Functions.GeneralFunction;

namespace FrameworkSolution.TestScripts
{
    /// <summary>
    /// Description of AddLineItem_in_EstimateView.
    /// </summary>
    [TestModule("B674E9D8-DAC3-45C3-A90A-3F7B6BDCC481", ModuleType.UserCode, 1)]
    public class AddLineItem_in_EstimateView : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddLineItem_in_EstimateView()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            
            //To Launch Application...
            BaseClass objLaunch = new BaseClass();
            objLaunch.Applaunch();
            Delay.Seconds(40);
            
            
            //To Create New_Estimate...
            CreateNewEstimate objCreate = new CreateNewEstimate();
            objCreate.Create_Estimate();
            //System.Diagnostics.Debug.WriteLine(objCreate.Driver.BarButtonItemLinkNewButtonItem);
            Delay.Seconds(20);
            
            
            //Add LineItem in Estimate view...
            AddLineItem objAd_LineItem = new AddLineItem();
            objAd_LineItem.Add_LineItem();
            Delay.Seconds(2);
            
            
            //To Close Application...
            objLaunch.AppClose();
            Delay.Seconds(25);
            
        }
        
    }
}
