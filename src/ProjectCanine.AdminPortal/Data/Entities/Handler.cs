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

    // Handlers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public class Handler
    {
        [Column(@"Id", Order = 1, TypeName = "uniqueidentifier")]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public System.Guid Id { get; set; } // Id (Primary key)

        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName (length: 100)

        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child TestResults where [TestResults].[Handler] point to this entity (FKTestResults_Handlers)
        /// </summary>
        public virtual System.Collections.Generic.List<TestResult> TestResults { get; set; } = new System.Collections.Generic.List<TestResult>(); // TestResults.FKTestResults_Handlers
    }

}
// </auto-generated>