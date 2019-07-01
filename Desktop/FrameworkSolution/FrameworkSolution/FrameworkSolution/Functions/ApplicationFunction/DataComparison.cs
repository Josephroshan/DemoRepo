/*
 * Created by Ranorex
 * User: Test
 * Date: 6/13/2019
 * Time: 3:14 PM
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

namespace FrameworkSolution.Functions.ApplicationFunction
{ /*
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class DataComparison : Obj_DataComparison
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        [UserCodeMethod]
        public void Data_Comp()
        {
        	
        	Obj_DataComparison obj7 = new Obj_DataComparison();
        	Delay.Seconds(3);
        	
 			//Calling Create_Estimate method in Data Comparison class...
        	CreateNewEstimate obj8 = new CreateNewEstimate();
        	obj8.Create_Estimate();
        	
        	//Calling ADD ASSEMBLY method in Data Comparison class...
        	AddAssembly obj9 = new AddAssembly();
        	obj9.Add_Assemby();
        	
        	
        	
        	//Calling CurrentImage from Object Repository...
        	Bitmap CaptureImage = Imaging.CaptureImage("/form[@name='Create New Estimate' and @visible='True']");
        	//Calling image from Base Location
        	Bitmap BaseImage = Imaging.Load(@"");
        	
        	
			// run through table-rows
			for (int iRow = 0; iRow = tableAdapter.Rows.Count - 1; iRow++)
			{
				int cellCountCur = tableAdapter.Rows[iRow].Cells.Count;
				int cellCountRef = refTable.Rows[iRow].Cells.Count;

				// check if number of cells is identical in current row
				if (cellCountCur != cellCountRef)
					{
						throw new Ranorex.ValidationException(String.Format("Table-Rows do not have same number of cells ({0} vs. {1})", cellCountCur, cellCountRef));
					}

				// run through cells in current row
				for (int iCol = 0; iCol = cellCountCur - 1; iCol++)
						{
							string aCurText = tableAdapter.Rows[iRow].Cells[iCol].As<ranorex.cell>().Text;
							string aRefText = refTable.Rows[iRow].Cells[iCol].As<ranorex.cell>().Text;
							string validationMessage = string.Empty;
							if (string.IsNullOrEmpty(customLogMessageDetail))
								{
									validationMessage = String.Format ("Comparing content of cell ({2}/{3}) (found:'{0}', expected: '{1}')", aCurText, aRefText, iRow,iCol);
								}
							else
								{
									validationMessage = customLogMessageDetail;
								}

				
							// validate whether current text and expected text are identical
								Ranorex.Validate.AreEqual (aCurText, aRefText, validationMessage);
						}
			}

			/// Log overall success
			if (string.IsNullOrEmpty(customLogMessageOverall))
			customLogMessageOverall = "Successfully completed content-validation of table with provided snapshot of table (reference)";
			Ranorex.Report.Log (ReportLevel.Success, customLogMessageOverall); 

        	
        	
        	
        	
        	
        }
    } */
}
