﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace PersonManagementTool.SystemTests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// StartApplication - Use 'StartApplicationParams' to pass parameters into this method.
        /// </summary>
        public void StartApplication()
        {

            // Launch '%USERPROFILE%\repos\Trapeze\Code\PersonManagementTool\PersonManagementTool.UI\bin\Debug\PersonManagementTool.UI.exe'
            ApplicationUnderTest personManagementToolUIApplication = ApplicationUnderTest.Launch(this.StartApplicationParams.ExePath, this.StartApplicationParams.AlternateExePath);
        }
        
        /// <summary>
        /// CloseWindow - Use 'CloseWindowParams' to pass parameters into this method.
        /// </summary>
        public void CloseWindow()
        {
            #region Variable Declarations
            WinTitleBar uIPersonManagementToolTitleBar = this.UIPersonManagementToolWindow.UIPersonManagementToolTitleBar;
            WinWindow uIPersonManagementToolWindow = this.UIPersonManagementToolWindow;
            #endregion

            // Click 'Person Management Tool' title bar
            Mouse.Click(uIPersonManagementToolTitleBar, new Point(477, 31));

            // Type 'Alt + {F4}' in 'Person Management Tool' window
            Keyboard.SendKeys(uIPersonManagementToolWindow, this.CloseWindowParams.UIPersonManagementToolWindowSendKeys, ModifierKeys.Alt);
        }
        
        #region Properties
        public virtual StartApplicationParams StartApplicationParams
        {
            get
            {
                if ((this.mStartApplicationParams == null))
                {
                    this.mStartApplicationParams = new StartApplicationParams();
                }
                return this.mStartApplicationParams;
            }
        }
        
        public virtual CloseWindowParams CloseWindowParams
        {
            get
            {
                if ((this.mCloseWindowParams == null))
                {
                    this.mCloseWindowParams = new CloseWindowParams();
                }
                return this.mCloseWindowParams;
            }
        }
        
        public UIPersonManagementToolWindow UIPersonManagementToolWindow
        {
            get
            {
                if ((this.mUIPersonManagementToolWindow == null))
                {
                    this.mUIPersonManagementToolWindow = new UIPersonManagementToolWindow();
                }
                return this.mUIPersonManagementToolWindow;
            }
        }
        #endregion
        
        #region Fields
        private StartApplicationParams mStartApplicationParams;
        
        private CloseWindowParams mCloseWindowParams;
        
        private UIPersonManagementToolWindow mUIPersonManagementToolWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'StartApplication'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class StartApplicationParams
    {
        
        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\repos\Trapeze\Code\PersonManagementTool\PersonManagementTool.UI\bin\Debug\PersonManagementTool.UI.exe'
        /// </summary>
        public string ExePath = "C:\\Users\\hendrik.loesch\\repos\\Trapeze\\Code\\PersonManagementTool\\PersonManagementT" +
            "ool.UI\\bin\\Debug\\PersonManagementTool.UI.exe";
        
        /// <summary>
        /// Launch '%USERPROFILE%\repos\Trapeze\Code\PersonManagementTool\PersonManagementTool.UI\bin\Debug\PersonManagementTool.UI.exe'
        /// </summary>
        public string AlternateExePath = "%USERPROFILE%\\repos\\Trapeze\\Code\\PersonManagementTool\\PersonManagementTool.UI\\bin" +
            "\\Debug\\PersonManagementTool.UI.exe";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'CloseWindow'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class CloseWindowParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'Alt + {F4}' in 'Person Management Tool' window
        /// </summary>
        public string UIPersonManagementToolWindowSendKeys = "{F4}";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIPersonManagementToolWindow : WinWindow
    {
        
        public UIPersonManagementToolWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Person Management Tool";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Person Management Tool");
            #endregion
        }
        
        #region Properties
        public WinTitleBar UIPersonManagementToolTitleBar
        {
            get
            {
                if ((this.mUIPersonManagementToolTitleBar == null))
                {
                    this.mUIPersonManagementToolTitleBar = new WinTitleBar(this);
                    #region Search Criteria
                    this.mUIPersonManagementToolTitleBar.WindowTitles.Add("Person Management Tool");
                    #endregion
                }
                return this.mUIPersonManagementToolTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private WinTitleBar mUIPersonManagementToolTitleBar;
        #endregion
    }
}
