//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm_V1.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class category
    {
        public category()
        {
            this.items = new HashSet<item>();
        }
    
        public int category_id { get; set; }
        public string category_name { get; set; }
    
        public virtual ICollection<item> items { get; set; }
    }
}