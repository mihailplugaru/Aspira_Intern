using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Reflection_Attributes
{
    //[AttributeUsage(AttributeTargets.Property)]
    public class AttributeValidation : ValidationAttribute
    {
        private string Message { get; set; }
        private int valid = 0;
        private int temp;

        public AttributeValidation()
        {
            Message = "Need a Numerical and an Alphanumerical input!";
                 //PropertyInfo[] myPropertyInfo;
                //myPropertyInfo = Type.GetType("System.Type").GetProperties();
                //Console.WriteLine("Properties of System.Type are:");
               //for (int i = 0; i < myPropertyInfo.Length; i++)
                //{
               //    Console.WriteLine(myPropertyInfo[i].ToString());
                     //}
            PropertyInfo[] fields = Type.GetType("System.Type").GetProperties();
            foreach (PropertyInfo field in fields)
            {
                bool isParsable = Int32.TryParse(field.ToString(), out temp);
                if (field.PropertyType == typeof(string) && !isParsable)
                {
                    valid++;
                }
            }
            if (valid != 1)
            {
                Console.WriteLine(Message);
            }
        }

        public override bool IsValid(object value)
        {
            return ;
        }
    }
}

