//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Deneme.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Version
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Version()
        {
            this.Release = new HashSet<Release>();
        }
    
        public int Id { get; set; }
        public string VersionName { get; set; }
        public string VersionImage { get; set; }
        public int MarkId { get; set; }
    
        public virtual Mark Mark { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Release> Release { get; set; }
    }
}
