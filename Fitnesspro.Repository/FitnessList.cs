//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fitnesspro.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class FitnessList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FitnessList()
        {
            this.PackageDetails = new HashSet<PackageDetail>();
        }
    
        public int FitnessId { get; set; }
        public string FitnessName { get; set; }
        public Nullable<int> EntityId { get; set; }
        public string HolderFirtName { get; set; }
        public string HolderLastName { get; set; }
        public Nullable<long> MobileNumber { get; set; }
        public string EntityAddress { get; set; }
        public Nullable<int> EstablishedYear { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> EnrollDate { get; set; }
        public Nullable<System.TimeSpan> Openat { get; set; }
        public Nullable<System.TimeSpan> Closeat { get; set; }
        public Nullable<long> PhoneNumber { get; set; }
        public string InstructionMessage { get; set; }
        public string About { get; set; }
        public string FeedBack { get; set; }
    
        public virtual EntityType EntityType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackageDetail> PackageDetails { get; set; }
    }
}
