/*
 * Created by Ranorex
 * User: Test
 * Date: 6/10/2019
 * Time: 4:30 PM
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

namespace FrameworkSolution.TestScripts
{
    /// <summary>
    /// Description of AddAssembly_in_Estimate_view.
    /// </summary>
    [TestModule("4D26F820-E12A-4960-9EE7-3BD8C36C5DD1", ModuleType.UserCode, 1)]
    public class AddAssembly_in_Estimate_view : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddAssembly_in_Estimate_view()
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
            
            
            //Add Assembly in Estimate view...
            AddAssembly objAd_Assmbly = new AddAssembly();
            objAd_Assmbly.Add_Assemby();
            Delay.Seconds(2);
            
            
            //To Close Application...
            objLaunch.AppClose();
            Delay.Seconds(25);
            
        }
    }
}
