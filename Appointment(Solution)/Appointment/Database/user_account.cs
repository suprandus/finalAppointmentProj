//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Appointment.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_account
    {
        public user_account()
        {
            this.user_information = new HashSet<user_information>();
        }
    
        public int user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    
        public virtual ICollection<user_information> user_information { get; set; }
    }
}
