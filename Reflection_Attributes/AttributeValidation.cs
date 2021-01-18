using System;
using System.ComponentModel.DataAnnotations;

namespace Reflection_Attributes
{
    //[AttributeUsage(AttributeTargets.Property)]
    public class AttributeValidation : ValidationAttribute
    {

        //public override bool IsValid(object value)
        //{
        //    if (int.TryParse(value.ToString(), out i))
        //    {
        //        return true;
        //    }
        //    else return false;
        //}



        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var instance = (TestClassPerson)validationContext.ObjectInstance;

            if ((int.TryParse(value.ToString(), out int _)) ^ (int.TryParse(instance.PersonsAge.ToString(), out int _)))
            {
                return ValidationResult.Success;
            }
            else return new ValidationResult("The inputs must not be the same data type");
        }
    }
}



















//protected override ValidationResult
//        IsValid(object value, ValidationContext validationContext)
//{
//    var model = (Reflection_Attributes.TestClassPerson)validationContext.ObjectInstance;
//    DateTime _lastDeliveryDate = Convert.ToDateTime(value);
//    DateTime _dateJoin = Convert.ToDateTime(model.JoinDate);

//    if (_dateJoin > _lastDeliveryDate)
//    {
//        return new ValidationResult
//            ("Last Delivery Date can not be less than Join date.");
//    }
//    else if (_lastDeliveryDate > DateTime.Now)
//    {
//        return new ValidationResult
//            ("Last Delivery Date can not be greater than current date.");
//    }
//    else
//    {
//        return ValidationResult.Success;
//    }
//}

