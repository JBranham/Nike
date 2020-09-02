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
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Nike_demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddUser recording.
    /// </summary>
    [TestModule("ac0b27b1-0309-4c34-851a-3bb209e9936b", ModuleType.Recording, 1)]
    public partial class AddUser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Nike_demoRepository repository.
        /// </summary>
        public static Nike_demoRepository repo = Nike_demoRepository.Instance;

        static AddUser instance = new AddUser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddUser()
        {
            FirstName = "Jay";
            LastName = "Branham";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddUser Instance
        {
            get { return instance; }
        }

#region Variables

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("346d26fd-28ba-43e7-99c2-7a1bf79fb862")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _LastName;

        /// <summary>
        /// Gets or sets the value of variable LastName.
        /// </summary>
        [TestVariable("81bc4832-b853-482d-ba77-9b1b90d4c232")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormVipApplication.FName' at .189;.563.", repo.FormVipApplication.FNameInfo, new RecordItemIndex(0));
            repo.FormVipApplication.FName.Click(".189;.563");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FirstName' with focus on 'FormVipApplication.FName'.", repo.FormVipApplication.FNameInfo, new RecordItemIndex(1));
            repo.FormVipApplication.FName.PressKeys(FirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormVipApplication.LastName' at Center.", repo.FormVipApplication.LastNameInfo, new RecordItemIndex(2));
            repo.FormVipApplication.LastName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LastName' with focus on 'FormVipApplication.LastName'.", repo.FormVipApplication.LastNameInfo, new RecordItemIndex(3));
            repo.FormVipApplication.LastName.PressKeys(LastName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormVipApplication.Movie' at .181;.538.", repo.FormVipApplication.MovieInfo, new RecordItemIndex(4));
            repo.FormVipApplication.Movie.Click(".181;.538");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormVipApplication.RbMale' at .125;.471.", repo.FormVipApplication.RbMaleInfo, new RecordItemIndex(5));
            repo.FormVipApplication.RbMale.Click(".125;.471");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormVipApplication.BtAdd' at .493;.391.", repo.FormVipApplication.BtAddInfo, new RecordItemIndex(6));
            repo.FormVipApplication.BtAdd.Click(".493;.391");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
