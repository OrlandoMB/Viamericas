//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViamericasCareers.Data.DataContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Candidate
    {
        public long Id { get; set; }
        public string CardId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public long JobId { get; set; }
        public System.DateTime RegDate { get; set; }
    
        public virtual Job Job { get; set; }
    }
}