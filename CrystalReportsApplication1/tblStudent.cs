//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrystalReportsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblStudent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblStudent()
        {
            this.tblPictures = new HashSet<tblPicture>();
        }
    
        public int StudentID { get; set; }
        public string RegisterationNumber { get; set; }
        public string RollNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string FormNumber { get; set; }
        public Nullable<int> ClassID { get; set; }
        public Nullable<int> CollegeID { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string mobile { get; set; }
        public string Subject { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPicture> tblPictures { get; set; }
        public virtual tblClass tblClass { get; set; }
        public virtual tblCollege tblCollege { get; set; }
    }
}