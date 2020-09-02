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

namespace Nike_demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Nike_demoRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("e46fe284-f4d4-44ac-aa69-2d39149fd748")]
    public partial class Nike_demoRepository : RepoGenBaseFolder
    {
        static Nike_demoRepository instance = new Nike_demoRepository();
        Nike_demoRepositoryFolders.FormVipApplicationAppFolder _formvipapplication;
        Nike_demoRepositoryFolders.ExplorerAppFolder _explorer;

        /// <summary>
        /// Gets the singleton class instance representing the Nike_demoRepository element repository.
        /// </summary>
        [RepositoryFolder("e46fe284-f4d4-44ac-aa69-2d39149fd748")]
        public static Nike_demoRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Nike_demoRepository() 
            : base("Nike_demoRepository", "/", null, 0, false, "e46fe284-f4d4-44ac-aa69-2d39149fd748", ".\\RepositoryImages\\Nike_demoRepositorye46fe284.rximgres")
        {
            _formvipapplication = new Nike_demoRepositoryFolders.FormVipApplicationAppFolder(this);
            _explorer = new Nike_demoRepositoryFolders.ExplorerAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e46fe284-f4d4-44ac-aa69-2d39149fd748")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FormVipApplication folder.
        /// </summary>
        [RepositoryFolder("8a9907f2-71a7-440e-9150-679185d71159")]
        public virtual Nike_demoRepositoryFolders.FormVipApplicationAppFolder FormVipApplication
        {
            get { return _formvipapplication; }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("c5d5f7da-d139-4852-9883-2cde7099803e")]
        public virtual Nike_demoRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Nike_demoRepositoryFolders
    {
        /// <summary>
        /// The FormVipApplicationAppFolder folder.
        /// </summary>
        [RepositoryFolder("8a9907f2-71a7-440e-9150-679185d71159")]
        public partial class FormVipApplicationAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _fnameInfo;
            RepoItemInfo _lastnameInfo;
            RepoItemInfo _musicInfo;
            RepoItemInfo _movieInfo;
            RepoItemInfo _rbmaleInfo;
            RepoItemInfo _btaddInfo;
            RepoItemInfo _vipcount1Info;
            RepoItemInfo _btclearInfo;
            RepoItemInfo _vipcount0Info;

            /// <summary>
            /// Creates a new FormVipApplication  folder.
            /// </summary>
            public FormVipApplicationAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FormVipApplication", "/form[@controlname='formVipApplication']", parentFolder, 30000, null, true, "8a9907f2-71a7-440e-9150-679185d71159", "")
            {
                _fnameInfo = new RepoItemInfo(this, "FName", "?/?/text[@accessiblename='First Name:']", 60000, null, "2f4fbaa0-424f-4042-a16f-b287e6b712d9");
                _lastnameInfo = new RepoItemInfo(this, "LastName", "?/?/text[@accessiblename='Last Name:']", 60000, null, "c216955a-bdb0-4555-9f04-e29f44a2713a");
                _musicInfo = new RepoItemInfo(this, "Music", ".//listitem[@accessiblename='Music']", 60000, null, "9e5f5396-2d18-41ef-a8ff-4aae1fd9329e");
                _movieInfo = new RepoItemInfo(this, "Movie", ".//listitem[@accessiblename='Movie']", 60000, null, "c1d8b3fe-5d5f-4eb0-a6bf-07076f28c14f");
                _rbmaleInfo = new RepoItemInfo(this, "RbMale", "?/?/radiobutton[@controlname='rbMale']", 60000, null, "ac8b6613-e5d6-4f71-b188-f1fafb9b521c");
                _btaddInfo = new RepoItemInfo(this, "BtAdd", "button[@controlname='btAdd']", 60000, null, "d622f8f3-1b55-4265-8530-c1fc700b0661");
                _vipcount1Info = new RepoItemInfo(this, "VIPCount1", "?/?/text[@accessiblename='VIP count: 1']", 60000, null, "39a26cd8-c6e3-4b2c-9f0d-129eb8b5986c");
                _btclearInfo = new RepoItemInfo(this, "BtClear", "button[@controlname='btClear']", 60000, null, "881f2c60-4cd5-4eb1-a4f4-97642af886a5");
                _vipcount0Info = new RepoItemInfo(this, "VIPCount0", "?/?/text[@accessiblename='VIP count: 0']", 60000, null, "ca0dba92-36bd-41be-90fb-2ac95a6a6437");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("8a9907f2-71a7-440e-9150-679185d71159")]
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
            [RepositoryItemInfo("8a9907f2-71a7-440e-9150-679185d71159")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The FName item.
            /// </summary>
            [RepositoryItem("2f4fbaa0-424f-4042-a16f-b287e6b712d9")]
            public virtual Ranorex.Text FName
            {
                get
                {
                    return _fnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The FName item info.
            /// </summary>
            [RepositoryItemInfo("2f4fbaa0-424f-4042-a16f-b287e6b712d9")]
            public virtual RepoItemInfo FNameInfo
            {
                get
                {
                    return _fnameInfo;
                }
            }

            /// <summary>
            /// The LastName item.
            /// </summary>
            [RepositoryItem("c216955a-bdb0-4555-9f04-e29f44a2713a")]
            public virtual Ranorex.Text LastName
            {
                get
                {
                    return _lastnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LastName item info.
            /// </summary>
            [RepositoryItemInfo("c216955a-bdb0-4555-9f04-e29f44a2713a")]
            public virtual RepoItemInfo LastNameInfo
            {
                get
                {
                    return _lastnameInfo;
                }
            }

            /// <summary>
            /// The Music item.
            /// </summary>
            [RepositoryItem("9e5f5396-2d18-41ef-a8ff-4aae1fd9329e")]
            public virtual Ranorex.ListItem Music
            {
                get
                {
                    return _musicInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Music item info.
            /// </summary>
            [RepositoryItemInfo("9e5f5396-2d18-41ef-a8ff-4aae1fd9329e")]
            public virtual RepoItemInfo MusicInfo
            {
                get
                {
                    return _musicInfo;
                }
            }

            /// <summary>
            /// The Movie item.
            /// </summary>
            [RepositoryItem("c1d8b3fe-5d5f-4eb0-a6bf-07076f28c14f")]
            public virtual Ranorex.ListItem Movie
            {
                get
                {
                    return _movieInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Movie item info.
            /// </summary>
            [RepositoryItemInfo("c1d8b3fe-5d5f-4eb0-a6bf-07076f28c14f")]
            public virtual RepoItemInfo MovieInfo
            {
                get
                {
                    return _movieInfo;
                }
            }

            /// <summary>
            /// The RbMale item.
            /// </summary>
            [RepositoryItem("ac8b6613-e5d6-4f71-b188-f1fafb9b521c")]
            public virtual Ranorex.RadioButton RbMale
            {
                get
                {
                    return _rbmaleInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The RbMale item info.
            /// </summary>
            [RepositoryItemInfo("ac8b6613-e5d6-4f71-b188-f1fafb9b521c")]
            public virtual RepoItemInfo RbMaleInfo
            {
                get
                {
                    return _rbmaleInfo;
                }
            }

            /// <summary>
            /// The BtAdd item.
            /// </summary>
            [RepositoryItem("d622f8f3-1b55-4265-8530-c1fc700b0661")]
            public virtual Ranorex.Button BtAdd
            {
                get
                {
                    return _btaddInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtAdd item info.
            /// </summary>
            [RepositoryItemInfo("d622f8f3-1b55-4265-8530-c1fc700b0661")]
            public virtual RepoItemInfo BtAddInfo
            {
                get
                {
                    return _btaddInfo;
                }
            }

            /// <summary>
            /// The VIPCount1 item.
            /// </summary>
            [RepositoryItem("39a26cd8-c6e3-4b2c-9f0d-129eb8b5986c")]
            public virtual Ranorex.Text VIPCount1
            {
                get
                {
                    return _vipcount1Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The VIPCount1 item info.
            /// </summary>
            [RepositoryItemInfo("39a26cd8-c6e3-4b2c-9f0d-129eb8b5986c")]
            public virtual RepoItemInfo VIPCount1Info
            {
                get
                {
                    return _vipcount1Info;
                }
            }

            /// <summary>
            /// The BtClear item.
            /// </summary>
            [RepositoryItem("881f2c60-4cd5-4eb1-a4f4-97642af886a5")]
            public virtual Ranorex.Button BtClear
            {
                get
                {
                    return _btclearInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtClear item info.
            /// </summary>
            [RepositoryItemInfo("881f2c60-4cd5-4eb1-a4f4-97642af886a5")]
            public virtual RepoItemInfo BtClearInfo
            {
                get
                {
                    return _btclearInfo;
                }
            }

            /// <summary>
            /// The VIPCount0 item.
            /// </summary>
            [RepositoryItem("ca0dba92-36bd-41be-90fb-2ac95a6a6437")]
            public virtual Ranorex.Text VIPCount0
            {
                get
                {
                    return _vipcount0Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The VIPCount0 item info.
            /// </summary>
            [RepositoryItemInfo("ca0dba92-36bd-41be-90fb-2ac95a6a6437")]
            public virtual RepoItemInfo VIPCount0Info
            {
                get
                {
                    return _vipcount0Info;
                }
            }
        }

        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("c5d5f7da-d139-4852-9883-2cde7099803e")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _startInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/menubar[@processname='explorer']", parentFolder, 30000, null, true, "c5d5f7da-d139-4852-9883-2cde7099803e", "")
            {
                _startInfo = new RepoItemInfo(this, "Start", "?/?/button[@accessiblename='Start']", 60000, null, "e7ee7d2d-6462-487f-8582-65ecd50addf5");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c5d5f7da-d139-4852-9883-2cde7099803e")]
            public virtual Ranorex.MenuBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MenuBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c5d5f7da-d139-4852-9883-2cde7099803e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Start item.
            /// </summary>
            [RepositoryItem("e7ee7d2d-6462-487f-8582-65ecd50addf5")]
            public virtual Ranorex.Button Start
            {
                get
                {
                    return _startInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Start item info.
            /// </summary>
            [RepositoryItemInfo("e7ee7d2d-6462-487f-8582-65ecd50addf5")]
            public virtual RepoItemInfo StartInfo
            {
                get
                {
                    return _startInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
