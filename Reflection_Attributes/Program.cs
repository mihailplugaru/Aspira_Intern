using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Reflection_Attributes
{
    class Program
    {
        static int allFieldAreValid;
        static void Main(string[] args)
        {
            TestClassPerson person1 = new TestClassPerson();
            Console.Write("Choose a name : ");
            person1.PersonsName = Console.ReadLine();
            Console.Write("Choose an age : ");
            person1.PersonsAge = Console.ReadLine();

            Console.WriteLine(person1);


            List<ValidationResult> list1 = new List<ValidationResult>();
            var context = new ValidationContext(person1, serviceProvider: null, items: null);
            Validator.TryValidateObject(person1, context ,list1,true);


            Validator.TryValidateObject(person1, context, list1, true);
            Console.WriteLine(String.Join("\n",list1));
            //Validate(person1);
            //if (allFieldAreValid != 1)
            //{
            //    Console.WriteLine("\nCannot accept the input - both fields are the same data type.");
            //}
            //else
            //{
            //    Console.WriteLine("\nThe input data seems to be ok.");
            //}

            Console.ReadKey();
        }

        //private static void Validate(object model)
        //{
        //    ValidationContext validationContext = new ValidationContext(model);
        //    foreach (var propertyInfo in model.GetType().GetProperties())
        //    {
        //        foreach (var attribute in propertyInfo.GetCustomAttributes(true))
        //        {
        //            var notNullAttribute = attribute as AttributeValidation;
        //            if (notNullAttribute != null)
        //            {
        //                Console.WriteLine(notNullAttribute.Validate(propertyInfo.GetValue(model), validationContext));
        //            }
        //        }
        //    }
        //}

        //private static void Validate(object model)
        //{
        //    allFieldAreValid = 0;
        //    foreach (var propertyInfo in model.GetType().GetProperties())
        //    {
        //        foreach (var attribute in propertyInfo.GetCustomAttributes(true))
        //        {
        //            var notNullAttribute = attribute as AttributeValidation;
        //            if (notNullAttribute != null)
        //            {
        //                if (notNullAttribute.IsValid(propertyInfo.GetValue(model)))
        //                {
        //                    allFieldAreValid++;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
