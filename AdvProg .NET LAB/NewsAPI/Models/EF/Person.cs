//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsAPI.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int person_Id { get; set; }
        public string person_name { get; set; }
        public string person_dob { get; set; }
        public int acc_ID { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
