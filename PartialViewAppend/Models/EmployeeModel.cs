using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewAppend.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string Designation { get; set; }

        public string Gender { get; set; }

        //public enum Gender
        //{
        //    Agender,
        //    Bigender,
        //    Cisgender,
        //    GenderExpression,
        //    GenderFluid,
        //    Genderqueer,
        //    Intersex,
        //    ThirdGender,
        //    Ze_Hir 
        //}
    }
}
