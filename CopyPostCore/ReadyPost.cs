//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CopyPostCore
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReadyPost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReadyPost()
        {
            this.Imgs = new HashSet<Img>();
            this.Spoilers = new HashSet<Spoiler>();
        }
    
        public int idReadyPost { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> FoundedTime { get; set; }
        public int FoundPost_idFoundPost { get; set; }
        public string TorrentUrl { get; set; }
    
        public virtual FoundPost FoundPost { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Img> Imgs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Spoiler> Spoilers { get; set; }
    }
}
