/*
 * Created by Ranorex
 * User: THI1903474
 * Date: 5/24/2019
 * Time: 10:00 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;
using FrameworkSolution.DemoObj__Repo;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace FrameworkSolution.Functions.ApplicationFunction
{
	/// <summary>
	/// Description of Add_Assembly.
	/// </summary>
	
	[UserCodeCollection]
	public class CreateNewEstimate : CreateEstimate
	{
		
		[UserCodeMethod]
		public void Create_Estimate() 
		{
			CreateEstimate obj3 = new CreateEstimate();
			
			Delay.Seconds(2);
			//obj3.Driver.BarButtonItemLinkNewButtonItemInfo.WaitForExists(90000); //waiting the object until visible
			
			Point NewButton = new Point(29,86);
			Mouse.MoveTo(NewButton);
			
			Mouse.Click(obj3.Driver.ButtonNew);
			Delay.Seconds(4);
			
			
			Mouse.Click(obj3.CreateNewEstimate.EName); //Giveing name to the Estimate
			Delay.Seconds(1);
			Random re = new Random();
			Keyboard.Press(obj3.CreateNewEstimate.EName, "S"+re.Next(1,1));
			Delay.Seconds(1);
			
			Mouse.Click(obj3.CreateNewEstimate.NewEstimate); 
			Delay.Seconds(5);

		}
		
	}
}
