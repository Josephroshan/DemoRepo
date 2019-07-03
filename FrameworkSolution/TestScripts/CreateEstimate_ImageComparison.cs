/*
 * Created by Ranorex
 * User: Test
 * Date: 6/13/2019
 * Time: 11:07 AM
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
using FrameworkSolution.Functions.ApplicationFunction;
using FrameworkSolution.Functions.GeneralFunction;

namespace FrameworkSolution.TestScripts
{
    /// <summary>
    /// Description of CreateEstimate_ImageComparison.
    /// </summary>
    [TestModule("4DE97340-2450-475F-858C-4C22E15997A1", ModuleType.UserCode, 1)]
    public class CreateEstimate_ImageComparison : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateEstimate_ImageComparison()
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
           //Delay.Seconds(80);
            
            //Imagecomparison..
            ImageComparison objImgComp =new ImageComparison();
            objImgComp.Img_Comp();
            Delay.Seconds(25);
            
            //To Close Application...
            objLaunch.AppClose();
            Delay.Seconds(5);
            
            	
            
            
        }
    }
}
