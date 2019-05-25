using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace NiceStopAutomated
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            ApplicationUnderTest.Launch(@"D:\Final Capstone\Application Files\NiceStop_1_0_0_16\NiceStop.exe");

            WinWindow UserLoginWindows = new WinWindow();
            UserLoginWindows.SearchProperties[WinWindow.PropertyNames.ControlName] = "metroTextBoxUsername";

            WinEdit UserLoginEdit = new WinEdit(UserLoginWindows);
            UserLoginEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";
            Keyboard.SendKeys(UserLoginEdit, "sanny");

            WinWindow ParentShowPass = new WinWindow();
            ParentShowPass.SearchProperties[WinWindow.PropertyNames.Name] = "Show Password";

            WinCheckBox UserPasswordShow = new WinCheckBox(ParentShowPass);
            UserPasswordShow.SearchProperties[WinCheckBox.PropertyNames.ControlType]= "CheckBox";
            Mouse.Click(UserPasswordShow);
            Mouse.Click(UserPasswordShow);

            WinWindow UserPasswordLoginWindows = new WinWindow();
            UserPasswordLoginWindows.SearchProperties[WinWindow.PropertyNames.ControlName] = "metroTextBoxPassword";

            WinEdit UserPasswordLoginEdit = new WinEdit(UserPasswordLoginWindows);
            UserPasswordLoginEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";
            Keyboard.SendKeys(UserPasswordLoginEdit, "sanny");

            WinWindow ParentLoginWindows = new WinWindow();
            ParentLoginWindows.SearchProperties[WinWindow.PropertyNames.Name] = "Login";

            WinClient LoginButton = new WinClient(ParentLoginWindows);
            LoginButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
            Mouse.Click(LoginButton);

            WinWindow Violators = new WinWindow();
            Violators.SearchProperties[WinWindow.PropertyNames.Name] = "Violator's List";

            WinClient ViolatorsButton = new WinClient(Violators);
            ViolatorsButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
            Mouse.Click(ViolatorsButton);
            Playback.Wait(2000);

            WinWindow ViolatorsUpadate = new WinWindow();
            ViolatorsUpadate.SearchProperties[WinWindow.PropertyNames.Name] = "Update";

            WinClient ViolatorsUpadateButton = new WinClient(ViolatorsUpadate);
            ViolatorsUpadateButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
            Mouse.Click(ViolatorsUpadateButton);
            Playback.Wait(3000);

            WinWindow Enforcers = new WinWindow();
            Enforcers.SearchProperties[WinWindow.PropertyNames.Name] = "Enforcer's List";

            WinClient EnforcersButton = new WinClient(Enforcers);
            EnforcersButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
            Mouse.Click(EnforcersButton);
            Playback.Wait(2000);

            WinWindow EnforcersUpadate = new WinWindow();
            EnforcersUpadate.SearchProperties[WinWindow.PropertyNames.Name] = "Update";

            WinClient EnforcersUpadateButton = new WinClient(EnforcersUpadate);
            EnforcersUpadateButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
            Mouse.Click(EnforcersUpadateButton);
            Playback.Wait(3000);

            WinWindow EnforcersRegistration = new WinWindow();
            EnforcersRegistration.SearchProperties[WinWindow.PropertyNames.Name] = "Enforcer's Registration";

            WinClient EnforcersRegistrationButton = new WinClient(EnforcersRegistration);
            EnforcersRegistrationButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
            Mouse.Click(EnforcersRegistrationButton);
            Playback.Wait(2000);

            WinWindow EnforcerFirstName = new WinWindow();
            EnforcerFirstName.SearchProperties[WinWindow.PropertyNames.ControlName] = "metroTextBoxFirstname";

            WinEdit EnforcerFirstNameEdit = new WinEdit(EnforcerFirstName);
            EnforcerFirstNameEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";
            Keyboard.SendKeys(EnforcerFirstNameEdit, "Sanny");

            WinWindow EnforcerLastname = new WinWindow();
            EnforcerLastname.SearchProperties[WinWindow.PropertyNames.ControlName] = "metroTextBoxLastname";

            WinEdit EnforcerLastnameEdit = new WinEdit(EnforcerLastname);
            EnforcerLastnameEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";
            Keyboard.SendKeys(EnforcerLastnameEdit, "Marinduque");

            WinWindow EnforcerAddress = new WinWindow();
            EnforcerAddress.SearchProperties[WinWindow.PropertyNames.ControlName] = "metroTextBoxAddress";

            WinEdit EnforcerAddressEdit = new WinEdit(EnforcerAddress);
            EnforcerAddressEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";
            Keyboard.SendKeys(EnforcerAddressEdit, "Parian, Cebu City");

            WinWindow EnforcerGender = new WinWindow();
            EnforcerGender.SearchProperties[WinWindow.PropertyNames.ControlName] = "metroComboBoxGender";

            WinComboBox EnforcerGenderChoose = new WinComboBox(EnforcerGender);
            EnforcerGenderChoose.SearchProperties[WinComboBox.PropertyNames.ControlType] = "ComboBox";
            Mouse.Click(EnforcerGenderChoose);

            WinWindow GenderMaleWindow = new WinWindow();
            GenderMaleWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "metroComboBoxGender";

            WinEdit GenderMale = new WinEdit(GenderMaleWindow);
            GenderMale.SearchProperties[WinEdit.PropertyNames.ControlType] = "ComboBox";
            Keyboard.SendKeys(GenderMale, "Male");

            WinWindow EnforcerBirthDateWindow = new WinWindow();
            EnforcerBirthDateWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "metroDateTimeBirthDate";

            WinEdit EnforcerBirthDate = new WinEdit(EnforcerBirthDateWindow);
            EnforcerBirthDate.SearchProperties[WinEdit.PropertyNames.ControlType] = "DateTimePicker";
            Keyboard.SendKeys(EnforcerBirthDate, "2000-08-23");

            WinWindow EnforcerContactWindow = new WinWindow();
            EnforcerContactWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "metroTextBoxContactNo";

            WinEdit EnforcerContact = new WinEdit(EnforcerContactWindow);
            EnforcerContact.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";
            Keyboard.SendKeys(EnforcerContact, "09111111111");

            WinWindow ParentShowPass2 = new WinWindow();
            ParentShowPass2.SearchProperties[WinWindow.PropertyNames.Name] = "Show Password";

            WinCheckBox UserPasswordShow2 = new WinCheckBox(ParentShowPass2);
            UserPasswordShow2.SearchProperties[WinCheckBox.PropertyNames.ControlType] = "CheckBox";
            Mouse.Click(UserPasswordShow2);
            Mouse.Click(UserPasswordShow2);

            WinWindow EnforcerPasswordWindow = new WinWindow();
            EnforcerPasswordWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "metroTextBoxPassword";

            WinEdit EnforcerPassword = new WinEdit(EnforcerPasswordWindow);
            EnforcerPassword.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";
            Keyboard.SendKeys(EnforcerPassword, "noname");

            WinWindow EnforcersCreate = new WinWindow();
            EnforcersCreate.SearchProperties[WinWindow.PropertyNames.Name] = "Create";

            WinClient EnforcersCreateButton = new WinClient(EnforcersCreate);
            EnforcersCreateButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
            Mouse.Click(EnforcersCreateButton);

            WinWindow EnforcersCreateOk = new WinWindow();
            EnforcersCreateOk.SearchProperties[WinWindow.PropertyNames.Name] = "OK";

            WinClient EnforcersCreateOkButton = new WinClient(EnforcersCreateOk);
            EnforcersCreateOkButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
            Mouse.Click(EnforcersCreateOkButton);

            WinWindow Enforcers2 = new WinWindow();
            Enforcers2.SearchProperties[WinWindow.PropertyNames.Name] = "Enforcer's List";

            WinClient EnforcersButton2 = new WinClient(Enforcers2);
            EnforcersButton2.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
            Mouse.Click(EnforcersButton2);
            Playback.Wait(2000);

            WinWindow EnforcersUpadate2 = new WinWindow();
            EnforcersUpadate2.SearchProperties[WinWindow.PropertyNames.Name] = "Update";

            WinClient EnforcersUpadateButton2 = new WinClient(EnforcersUpadate2);
            EnforcersUpadateButton2.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
            Mouse.Click(EnforcersUpadateButton2);
            Playback.Wait(4000);

            WinWindow LogoutWindow = new WinWindow();
            LogoutWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Logout";

            WinClient LogoutButton = new WinClient(LogoutWindow);
            LogoutButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
            Mouse.Click(LogoutButton);

        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
