/*
 * Created by Ranorex
 * User: Test
 * Date: 6/7/2019
 * Time: 4:54 PM
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
using FrameworkSolution.Functions.GeneralFunction;
using FrameworkSolution.Functions.ApplicationFunction;
using FrameworkSolution.ObjectRepository;

namespace FrameworkSolution
{
    /// <summary>
    /// Description of ToCraeteNewEstimate.
    /// </summary>
    [TestModule("C29CFE7E-3E95-46D8-A68D-6A5E6C4848D5", ModuleType.UserCode, 1)]
    public class ToCraeteNewEstimate : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ToCraeteNewEstimate()
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
            Delay.Seconds(4);
            
            
            //To Create New_Estimate...
            CreateNewEstimate objCreate = new CreateNewEstimate();
            objCreate.Create_Estimate();
            //System.Diagnostics.Debug.WriteLine(objCreate.Driver.BarButtonItemLinkNewButtonItem);
            Delay.Seconds(5);
            
            
            //To Close Application...
            objLaunch.AppClose();
            Delay.Seconds(5);
            
        }
    }
}
