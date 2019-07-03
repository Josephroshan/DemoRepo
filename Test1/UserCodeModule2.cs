/*
 * Created by Ranorex
 * User: THI1607232
 * Date: 22-05-2019
 * Time: 13:44
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
    /// Description of UserCodeModule2.
    /// </summary>
    [TestModule("D1C491C6-0CA9-4D42-A68A-DC0E9182B079", ModuleType.UserCode, 1)]
    public class UserCodeModule2 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule2()
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
