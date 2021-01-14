using System;


namespace Reflection_Attributes
{
    public class TestClassPerson
    {
        [AttributeValidation]
        public  string PersonsName { get; set; }

        //[AttributeValidation]
        public string PersonsAge { get; set; }



        public override string ToString()
        {
            return $"\nPerson :  {PersonsName}  -  {PersonsAge}"; 
        }
    }
}
