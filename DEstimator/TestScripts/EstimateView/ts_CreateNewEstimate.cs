/*
 * Created by Ranorex
 * User: THI1901449
 * Date: 07/02/2019
 * Time: 16:54
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

using DEstimator.Functions.GeneralFunction;
using DEstimator.Functions.ApplicationFunction.EstimateView;
using DEstimator.Repository.EstimateView;

namespace DEstimator.TestScripts.EstimateView
{
    /// <summary>
    /// Description of CreateNewEstimate.
    /// </summary>
    [TestModule("57155396-B431-4B00-AB47-CFD7C0BCF165", ModuleType.UserCode, 1)]
    public class Ts_CreateNewEstimate : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ts_CreateNewEstimate()
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
            GeneralFunction objLaunch = new GeneralFunction();
            objLaunch.Applaunch();
            //Delay.Seconds(40);
            
            
            //To Create New_Estimate...
            objLaunch.Create_Estimate();
            
            
            //To Close Application...
            objLaunch.AppClose();
            
        }
        
		
    }
}
