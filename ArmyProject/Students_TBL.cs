//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArmyProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Students_TBL()
        {
            this.Student_Sanctions_TBL = new HashSet<Student_Sanctions_TBL>();
        }
    
        public int Id { get; set; }
        public int GeneralNumber { get; set; }
        public Nullable<int> Company { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public string RecruitingArea { get; set; }
        public string Governorate { get; set; }
        public Nullable<int> ArrivalStations_Id { get; set; }
        public Nullable<int> Degree_Id { get; set; }
        public Nullable<int> RecruitingArea_Id { get; set; }
        public Nullable<int> Governorate_Id { get; set; }
        public string Rank { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<System.DateTime> BirthOfDate { get; set; }
        public string Address { get; set; }
        public Nullable<int> Battalion { get; set; }
        public string Weapon { get; set; }
        public Nullable<int> Evaluation { get; set; }
    
        public virtual ArrivalStations_TBL ArrivalStations_TBL { get; set; }
        public virtual Degree_TBL Degree_TBL { get; set; }
        public virtual Governorates_TBL Governorates_TBL { get; set; }
        public virtual RecruitingArea_TBL RecruitingArea_TBL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Sanctions_TBL> Student_Sanctions_TBL { get; set; }
    }
}
