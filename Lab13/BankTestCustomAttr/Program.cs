using CustomAttribute;
using System;

namespace BankTestCustomAttr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo attrInfo;
            attrInfo = typeof(Rational);

            //object[] attrs = attrInfo.GetCustomAttributes(false);
            object[] attrs = attrInfo.GetCustomAttributes(typeof(DeveloperInfoAttribute), false);
            CustomAttribute.DeveloperInfoAttribute developerAttr;

            //developerAttr = (CustomAttribute.DeveloperInfoAttribute)attrs[0];
            //Console.WriteLine("Developer: {0}\tDate: {1}", developerAttr.Developer, developerAttr.Date);
            //developerAttr = (CustomAttribute.DeveloperInfoAttribute)attrs[1];
            //Console.WriteLine("Developer: {0}\tDate: {1}", developerAttr.Developer, developerAttr.Date);

            foreach (CustomAttribute.DeveloperInfoAttribute devAttr in attrs)
            {
                Console.WriteLine("Developer: {0}\tDate: {1}", devAttr.Developer, devAttr.Date);
            }
        }
    }
}
