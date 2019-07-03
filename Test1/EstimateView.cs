/*
 * Created by Ranorex
 * User: THI1607232
 * Date: 22-05-2019
 * Time: 13:43
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

namespace Test1
{
    /// <summary>
    /// Description of EstimateView.
    /// </summary>
    [TestModule("9E877165-F897-448C-A727-9F5D569B171C", ModuleType.UserCode, 1)]
    public class EstimateView : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EstimateView()
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
        }
    }
}
