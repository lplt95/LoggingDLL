//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoggingDLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class USERS_DATA
    {
        public string user_login { get; set; }
        public string user_password { get; set; }
        public int role_id { get; set; }
        public bool need_password_change { get; set; }
        public string user_email { get; set; }
    
        public virtual ROLES ROLES { get; set; }
    }
}
