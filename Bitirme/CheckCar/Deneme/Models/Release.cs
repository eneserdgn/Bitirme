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
    
    public partial class Release
    {
        public int Id { get; set; }
        public string ReleaseName { get; set; }
        public string ReleaseYear { get; set; }
        public string Price { get; set; }
        public byte[] OnSale { get; set; }
        public int VersionId { get; set; }
    
        public virtual CarDetail CarDetail { get; set; }
        public virtual Version Version { get; set; }
    }
}
