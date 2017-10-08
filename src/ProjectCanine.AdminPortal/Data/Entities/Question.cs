// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCanine.AdminPortal.Data.Entities
{

    // Questions
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public class Question
    {
        [Column(@"Id", Order = 1, TypeName = "uniqueidentifier")]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public System.Guid Id { get; set; } // Id (Primary key)

        [Required]
        [Display(Name = "Test")]
        public System.Guid Test { get; set; } // Test

        [Required]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Text")]
        public string Text { get; set; } // Text (length: 1000)

        [Required]
        [Display(Name = "Must pass")]
        public bool MustPass { get; set; } = false; // MustPass

        [Required]
        [Display(Name = "Section number")]
        public int SectionNumber { get; set; } // SectionNumber

        [Required]
        [Display(Name = "Question number")]
        public int QuestionNumber { get; set; } // QuestionNumber

        [Required]
        [Display(Name = "Has yes no")]
        public bool HasYesNo { get; set; } = false; // HasYesNo

        [Display(Name = "Last edited by")]
        public System.Guid? LastEditedBy { get; set; } // LastEditedBy

        [Required]
        [Display(Name = "Last edited date")]
        public System.DateTime LastEditedDate { get; set; } = System.DateTime.Now; // LastEditedDate

        // Reverse navigation

        /// <summary>
        /// Child TestResultsAnswers where [TestResultsAnswers].[Question] point to this entity (FKTestResultsAnswers_Questions)
        /// </summary>
        public virtual System.Collections.Generic.List<TestResultsAnswer> TestResultsAnswers { get; set; } = new System.Collections.Generic.List<TestResultsAnswer>(); // TestResultsAnswers.FKTestResultsAnswers_Questions

        // Foreign keys

        /// <summary>
        /// Parent Examiner pointed by [Questions].([LastEditedBy]) (FKQuestions_Examiners)
        /// </summary>
        public virtual Examiner Examiner_LastEditedBy { get; set; } // FKQuestions_Examiners

        /// <summary>
        /// Parent Examiner pointed by [Questions].([LastEditedBy]) (FK_Questions_Examiners)
        /// </summary>
        public virtual Examiner Examiner1 { get; set; } // FK_Questions_Examiners

        /// <summary>
        /// Parent Test pointed by [Questions].([Test]) (FK_Questions_Tests)
        /// </summary>
        public virtual Test Test1 { get; set; } // FK_Questions_Tests

        /// <summary>
        /// Parent Test pointed by [Questions].([Test]) (FKQuestions_Tests)
        /// </summary>
        public virtual Test Test2 { get; set; } // FKQuestions_Tests
    }

}
// </auto-generated>
