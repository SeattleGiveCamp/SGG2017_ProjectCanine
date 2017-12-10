//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCanine.AdminPortal2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            this.TestResultsAnswers = new HashSet<TestResultsAnswer>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid Test { get; set; }
        public string Text { get; set; }
        public bool MustPass { get; set; }
        public System.Guid Section { get; set; }
        public int QuestionNumber { get; set; }
        public bool HasYesNo { get; set; }
        public Nullable<System.Guid> LastEditedBy { get; set; }
        public System.DateTime LastEditedDate { get; set; }
    
        public virtual Examiner Examiner { get; set; }
        public virtual Section Section1 { get; set; }
        public virtual Test Test1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestResultsAnswer> TestResultsAnswers { get; set; }
    }
}