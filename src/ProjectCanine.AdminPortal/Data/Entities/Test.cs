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
    using Newtonsoft.Json;

    // Tests
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public class Test
    {
        [Column(@"Id", Order = 1, TypeName = "uniqueidentifier")]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public System.Guid Id { get; set; } // Id (Primary key)

        [Required]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Short name")]
        public string ShortName { get; set; } // ShortName (length: 30)

        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (length: 500)

        [Required]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Handler signature text")]
        public string HandlerSignatureText { get; set; } // HandlerSignatureText (length: 1000)

        [Required]
        [Display(Name = "Last edited by")]
        public System.Guid LastEditedBy { get; set; } // LastEditedBy

        [Required]
        [Display(Name = "Last edited date")]
        public System.DateTime LastEditedDate { get; set; } = System.DateTime.Now; // LastEditedDate

        // Reverse navigation

        /// <summary>
        /// Child Questions where [Questions].[Test] point to this entity (FKQuestions_Tests)
        /// </summary>
        [JsonIgnore]
        public System.Collections.Generic.List<Question> Questions_Test { get; set; } = new System.Collections.Generic.List<Question>(); // Questions.FKQuestions_Tests
        /// <summary>
        /// Child Questions where [Questions].[Test] point to this entity (FK_Questions_Tests)
        /// </summary>
        [JsonIgnore]
        public System.Collections.Generic.List<Question> Questions1 { get; set; } = new System.Collections.Generic.List<Question>(); // Questions.FK_Questions_Tests
        /// <summary>
        /// Child Sections where [Sections].[Test] point to this entity (FKSections_Tests)
        /// </summary>
        [JsonIgnore]
        public System.Collections.Generic.List<Section> Sections { get; set; } = new System.Collections.Generic.List<Section>(); // Sections.FKSections_Tests
        /// <summary>
        /// Child TestResults where [TestResults].[Test] point to this entity (FKTestResults_Tests)
        /// </summary>
        [JsonIgnore]
        public System.Collections.Generic.List<TestResult> TestResults { get; set; } = new System.Collections.Generic.List<TestResult>(); // TestResults.FKTestResults_Tests

        // Foreign keys

        /// <summary>
        /// Parent Examiner pointed by [Tests].([LastEditedBy]) (FKTests_Examiners)
        /// </summary>
        [JsonIgnore]
        public Examiner Examiner { get; set; } // FKTests_Examiners
    }

}
// </auto-generated>
