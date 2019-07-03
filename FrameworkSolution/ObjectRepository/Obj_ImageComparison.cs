﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace FrameworkSolution.ObjectRepository
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Obj_ImageComparison element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("b0409bbb-90da-4cff-896d-536bf570cb8a")]
    public partial class Obj_ImageComparison : RepoGenBaseFolder
    {
        static Obj_ImageComparison instance = new Obj_ImageComparison();
        Obj_ImageComparisonFolders.DriverAppFolder _driver;
        Obj_ImageComparisonFolders.CreateNewEstimateAppFolder _createnewestimate;

        /// <summary>
        /// Gets the singleton class instance representing the Obj_ImageComparison element repository.
        /// </summary>
        [RepositoryFolder("b0409bbb-90da-4cff-896d-536bf570cb8a")]
        public static Obj_ImageComparison Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Obj_ImageComparison() 
            : base("Obj_ImageComparison", "/", null, 0, false, "b0409bbb-90da-4cff-896d-536bf570cb8a", ".\\RepositoryImages\\Obj_ImageComparisonb0409bbb.rximgres")
        {
            _driver = new Obj_ImageComparisonFolders.DriverAppFolder(this);
            _createnewestimate = new Obj_ImageComparisonFolders.CreateNewEstimateAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("b0409bbb-90da-4cff-896d-536bf570cb8a")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Driver folder.
        /// </summary>
        [RepositoryFolder("bd87764d-dc1c-4470-a854-2420f4d0dab6")]
        public virtual Obj_ImageComparisonFolders.DriverAppFolder Driver
        {
            get { return _driver; }
        }

        /// <summary>
        /// The CreateNewEstimate folder.
        /// </summary>
        [RepositoryFolder("55827566-43cf-41cf-9c6b-99bb4fb38f22")]
        public virtual Obj_ImageComparisonFolders.CreateNewEstimateAppFolder CreateNewEstimate
        {
            get { return _createnewestimate; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Obj_ImageComparisonFolders
    {
        /// <summary>
        /// The DriverAppFolder folder.
        /// </summary>
        [RepositoryFolder("bd87764d-dc1c-4470-a854-2420f4d0dab6")]
        public partial class DriverAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _barbuttonitemlinknewbuttonitemInfo;

            /// <summary>
            /// Creates a new Driver  folder.
            /// </summary>
            public DriverAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Driver", "/form[@name='DESTINI Estimator' and @classname='Window']", parentFolder, 30000, null, true, "bd87764d-dc1c-4470-a854-2420f4d0dab6", "")
            {
                _barbuttonitemlinknewbuttonitemInfo = new RepoItemInfo(this, "BarButtonItemLinkNewButtonItem", "container[@automationid='m_RibbonControl']//button[@text='New' and @visible='True']", 30000, null, "21a5d928-5bc1-4ccc-91a3-87c96ac76b72");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("bd87764d-dc1c-4470-a854-2420f4d0dab6")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("bd87764d-dc1c-4470-a854-2420f4d0dab6")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The BarButtonItemLinkNewButtonItem item.
            /// </summary>
            [RepositoryItem("21a5d928-5bc1-4ccc-91a3-87c96ac76b72")]
            public virtual Ranorex.Button BarButtonItemLinkNewButtonItem
            {
                get
                {
                    return _barbuttonitemlinknewbuttonitemInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BarButtonItemLinkNewButtonItem item info.
            /// </summary>
            [RepositoryItemInfo("21a5d928-5bc1-4ccc-91a3-87c96ac76b72")]
            public virtual RepoItemInfo BarButtonItemLinkNewButtonItemInfo
            {
                get
                {
                    return _barbuttonitemlinknewbuttonitemInfo;
                }
            }
        }

        /// <summary>
        /// The CreateNewEstimateAppFolder folder.
        /// </summary>
        [RepositoryFolder("55827566-43cf-41cf-9c6b-99bb4fb38f22")]
        public partial class CreateNewEstimateAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _partcontenthostInfo;
            RepoItemInfo _newestimateInfo;
            RepoItemInfo _partclosebuttonInfo;

            /// <summary>
            /// Creates a new CreateNewEstimate  folder.
            /// </summary>
            public CreateNewEstimateAppFolder(RepoGenBaseFolder parentFolder) :
                    base("CreateNewEstimate", "/form[@name='Create New Estimate' and @visible='True']", parentFolder, 30000, null, true, "55827566-43cf-41cf-9c6b-99bb4fb38f22", "")
            {
                _partcontenthostInfo = new RepoItemInfo(this, "PARTContentHost", ".//text[@automationid='EstimateNameTextEdit']/text[@automationid='PART_Editor']/container[@automationid='PART_ContentHost' and @visible='True']", 30000, null, "32c4fc5d-37f4-411f-80ae-f975a2bb5fd4");
                _newestimateInfo = new RepoItemInfo(this, "NewEstimate", "?/?/text[@name='New Estimate' and @text='New Estimate']", 30000, null, "fdd8ff26-15b3-437b-84c0-892c1863a3d2");
                _partclosebuttonInfo = new RepoItemInfo(this, "PARTCloseButton", "button[@automationid='PART_CloseButton' and @visible='True']", 30000, null, "c7afc095-ce80-4e5e-89a4-3ffe2954ad6d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("55827566-43cf-41cf-9c6b-99bb4fb38f22")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("55827566-43cf-41cf-9c6b-99bb4fb38f22")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PARTContentHost item.
            /// </summary>
            [RepositoryItem("32c4fc5d-37f4-411f-80ae-f975a2bb5fd4")]
            public virtual Ranorex.Container PARTContentHost
            {
                get
                {
                    return _partcontenthostInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The PARTContentHost item info.
            /// </summary>
            [RepositoryItemInfo("32c4fc5d-37f4-411f-80ae-f975a2bb5fd4")]
            public virtual RepoItemInfo PARTContentHostInfo
            {
                get
                {
                    return _partcontenthostInfo;
                }
            }

            /// <summary>
            /// The NewEstimate item.
            /// </summary>
            [RepositoryItem("fdd8ff26-15b3-437b-84c0-892c1863a3d2")]
            public virtual Ranorex.Text NewEstimate
            {
                get
                {
                    return _newestimateInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The NewEstimate item info.
            /// </summary>
            [RepositoryItemInfo("fdd8ff26-15b3-437b-84c0-892c1863a3d2")]
            public virtual RepoItemInfo NewEstimateInfo
            {
                get
                {
                    return _newestimateInfo;
                }
            }

            /// <summary>
            /// The PARTCloseButton item.
            /// </summary>
            [RepositoryItem("c7afc095-ce80-4e5e-89a4-3ffe2954ad6d")]
            public virtual Ranorex.Button PARTCloseButton
            {
                get
                {
                    return _partclosebuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PARTCloseButton item info.
            /// </summary>
            [RepositoryItemInfo("c7afc095-ce80-4e5e-89a4-3ffe2954ad6d")]
            public virtual RepoItemInfo PARTCloseButtonInfo
            {
                get
                {
                    return _partclosebuttonInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
