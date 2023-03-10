using System;
using System.Reflection;
using DescriptionAttribute = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;

namespace WD_UFT_Selenium_Auto.Library.BaseLibrary
{
    public class CaseAttribute
    {

    }
    public static class DescriptionExtension
    {
        public static string GetDescription(this Enum em)
        {
            Type type = em.GetType();
            FieldInfo fd = type.GetField(em.ToString());
            string des = fd.GetDescription();
            return des;
        }
        public static string GetDescription(this Type type, string methodName)
        {
            MethodInfo pro = type.GetMethod(methodName);
            string des = null;
            if (pro != null)
            {
                des = pro.GetDescription();
            }
            return des;
        }
        public static string GetDescription(this MemberInfo info)
        {
            var attrs = (System.ComponentModel.DescriptionAttribute[])info.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
            string des = info.Name;
            foreach (System.ComponentModel.DescriptionAttribute attr in attrs)
            {
                des = attr.Description;
            }
            return des;
        }

    }
    public static class Base_Attribute
    {
        public static string GetTestDescription(MethodBase testMethodInfo)
        {

            var t = (DescriptionAttribute)testMethodInfo.GetCustomAttribute(typeof(DescriptionAttribute));
            return t == null ? string.Empty : t.Description;
        }

        public static string GetTestDescription(Type type)
        {
            string _caseDescript = null;
            var method = type.GetMethods();
            foreach (MethodInfo item in method)
            {
                if (item.Name.Contains("VSTS_"))
                {
                    _caseDescript = GetTestDescription(item);
                    break;
                }
            }
            return _caseDescript;
        }

    }
    public class TitleAttribute : Attribute
    {
        public string Title { get; set; }

        public TitleAttribute(string title)
        {
            Title = title;
        }
    }
    public class TestCaseIDAttribute : Attribute
    {
        public int TestCaseID { get; set; }

        public TestCaseIDAttribute(int testcaseid)
        {
            TestCaseID = testcaseid;
        }
    }
    public class NameAttribute : Attribute
    {
        public string Name { get; set; }

        public NameAttribute(string name)
        {
            Name = name;
        }
    }

    /// <summary>
    /// Test case engineer
    /// </summary>
    public class AutomationEngineer
    {
        public const string Ziwei = "Ziwei Cao";
        public const string Ziru = "Ziru Huang";

    }
    /// <summary>
    /// Username&passwork
    /// </summary>
    public class UserName
    {
        public const string qaone1 = "qae\\qaone1";
        public const string qaone2 = "qae\\qaone2";

    }
    public class PassWord
    {
        public const string qaone1 = "Aspen111";
        public const string qaone2 = "Aspen111";

    }
 

    /// <summary>
    /// Test case owner
    /// </summary>
    public class CaseOwner
    {
        public const string Ziwei = "Ziwei Cao";
        public const string Ziru = "Ziru Huang";
    }

    /// <summary>
    /// Test case Priority
    /// </summary>
    public class CasePriority
    {
        public const int Critical = 1;
        public const int High = 2;
        public const int Medium = 3;
        public const int Low = 4;

    }

    /// <summary>
    /// Automation Tools
    /// </summary>
    public class AutomationTool
    {
        public const string UFT_Dev = "UFT Developer";
        public const string Silk_4Net = "Silk 4Net";
        public const string FlaUI = "FlaUI";
        public const string Selenium = "Selenium";
        public const string UFT_Selenium = "UFT Developer and Selenium";
        public const string UFT_FlaUI = "UFT Developer and FlaUI";

    }

    /// <summary>
    /// Automation State
    /// </summary>
    /// 
    public class CaseState
    {
        public const string Accepted = "State.Accepted";
        public const string Created = "State.Created";
        public const string Started = "State.Started";
        public const string Broken = "State.Broken";
    }

    /// <summary>
    /// metadata of a test method to indicate area and status
    /// </summary>
    /// 
    public class ProductArea
    {
        public const string WD = "Area.Weigh and Dispense";
        //public const string AITraining = "Area.AITraining";
        //public const string PSV = "Area.PSV";

    }

    public class Browser
    {
        public const string chrome = "chrome";
        public const string edge = "edge";

    }
    public class WDWebTab
    {
        public const string admin = "Administration";
        public const string material = "Material";
        public const string inventory = "Inventory";
        public const string order = "Order";
        public const string report = "Report";
        public const string equipment = "Equipment";



    }


    public class WDMethod
    {
        public const string Net = "Net weigh";
        public const string Manual = "Manual";


    }

    public class WDMaterial
    {
        public const string X0125 = "X0125";


    }

    public class AFWRole
    {
        public const string User = "Production Execution User";
        public const string Admin = "Production Execution Administrator";

    }

}