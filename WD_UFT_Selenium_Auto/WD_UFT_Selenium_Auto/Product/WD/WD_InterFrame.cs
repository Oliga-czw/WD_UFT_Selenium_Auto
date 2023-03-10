using HP.LFT.SDK;
using HP.LFT.SDK.Java;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WD_UFT_Selenium_Auto.Library.UFTLibrary;

namespace WD_UFT_Selenium_Auto.Product.WD
{


    public class ClassMainInterFrame : UFT_InterFrame
    {

        public ClassMainInterFrame(ITestObject parentObject, string xpath) : base(parentObject, xpath)
        {
        }

    }


    public class Login_InterFrame : ClassMainInterFrame
    {
        public Login_InterFrame(ITestObject parentObject, string xpath) : base(parentObject, xpath)
        {
        }

        public UFT_Editor userNameEditor => new UFT_Editor(_UFT_InterFrame, "//Editor[@AttachedText = 'User name:']");
        public UFT_Editor passwordEditor => new UFT_Editor(_UFT_InterFrame, "//Editor[@AttachedText = 'Password:']");
        public UFT_Button loginbutton => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'Button0']");
    }

    public class Home_InterFrame : ClassMainInterFrame
    {
        public Home_InterFrame(ITestObject parentObject, string xpath) : base(parentObject, xpath)
        {
        }

        //public UFT_Editor userNameEditor => new UFT_Editor(_UFT_InterFrame, "//Editor[@AttachedText = 'User name:']");
        //public UFT_Editor passwordEditor => new UFT_Editor(_UFT_InterFrame, "//Editor[@AttachedText = 'Password:']");
        public UFT_Button OrderDispensing => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'btnOrderDispense']");
        public UFT_Button OpenWeigh => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'btnOpenWeigh']");

    }


    public class Dispensing_InterFrame : ClassMainInterFrame
    {
        public Dispensing_InterFrame(ITestObject parentObject, string xpath) : base(parentObject, xpath)
        {
        }

        //public UFT_Editor userNameEditor => new UFT_Editor(_UFT_InterFrame, "//Editor[@AttachedText = 'User name:']");
        //public UFT_Editor passwordEditor => new UFT_Editor(_UFT_InterFrame, "//Editor[@AttachedText = 'Password:']");
        public UFT_Table orderTable => new UFT_Table(_UFT_InterFrame, "//Table[@AttachedText = 'Orders:']");
        public UFT_Button next => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'btnNext']");
    }

    public class Material_InterFrame : ClassMainInterFrame
    {
        public Material_InterFrame(ITestObject parentObject, string xpath) : base(parentObject, xpath)
        {
        }

        public UFT_Table materialTable => new UFT_Table(_UFT_InterFrame, "//Table[@AttachedText = 'Materials:']");
        public UFT_Button next => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'MaterialNext']");
    }

    public class BoothClean_InterFrame : ClassMainInterFrame
    {
        public BoothClean_InterFrame(ITestObject parentObject, string xpath) : base(parentObject, xpath)
        {
        }
        public UFT_Button cleanComplete => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'Cleaning']");
    }
    public class Handle_Information_InterFrame : ClassMainInterFrame
    {
        public Handle_Information_InterFrame(ITestObject parentObject, string xpath) : base(parentObject, xpath)
        {
        }
        public UFT_Button Acknowledge => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'btnAcknowledge']");
    }
    public class ScaleWeight_InterFrame : ClassMainInterFrame
    {
        public ScaleWeight_InterFrame(ITestObject parentObject, string xpath) : base(parentObject, xpath)
        {
        }

        public UFT_List dispense_method => new UFT_List(_UFT_InterFrame, "//List[@TagName = 'Dispense method:']");
        public UFT_List scale => new UFT_List(_UFT_InterFrame, "//List[@TagName = 'Scale:']");
        public UFT_Editor barcode => new UFT_Editor(_UFT_InterFrame, "//Editor[@AttachedText = 'Source Container Barcode:']");
        public UFT_Button zero => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'zeroBtn']");
        public UFT_Button tare => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'tareBtn']");
        public UFT_Button accept => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'btnAccept']");

        public UFT_Editor tare_editor => new UFT_Editor(_UFT_InterFrame, "//Editor[@AttachedText = 'Tare:']");

        public UFT_Editor net_editor => new UFT_Editor(_UFT_InterFrame, "//Editor[@AttachedText = 'Net:']");
    }
    public class OpenWeight_InterFrame : ClassMainInterFrame
    {
        public OpenWeight_InterFrame(ITestObject parentObject, string xpath) : base(parentObject, xpath)
        {
        }

        public UFT_List Scale_select => new UFT_List(_UFT_InterFrame, "//List[@ObjectName = 'comboScale']");
        public UFT_Button zero => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'btnZero']");
        public UFT_Button tare => new UFT_Button(_UFT_InterFrame, "//Button[@ObjectName = 'btnTare']");
        public UFT_Label ScaleReading => new UFT_Label(_UFT_InterFrame, "//Label[@ObjectName = 'lblScaleReading']");
        public UFT_Label TarestLabel => new UFT_Label(_UFT_InterFrame, "//Label[@ObjectName = 'displayTare']");
        public UFT_Label NetstLabel => new UFT_Label(_UFT_InterFrame, "//Label[@ObjectName = 'displayNet']");
        public UFT_Label GrossstLabel => new UFT_Label(_UFT_InterFrame, "//Label[@ObjectName = 'displayGross']");
    }
}
