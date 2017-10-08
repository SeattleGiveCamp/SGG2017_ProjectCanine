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


namespace ProjectCanine.AdminPortal.Data
{
    using ProjectCanine.AdminPortal.Data.EfCfgs;
    using ProjectCanine.AdminPortal.Data.Entities;

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public class CanineProjDbContext : System.Data.Entity.DbContext, ICanineProjDbContext
    {
        public System.Data.Entity.DbSet<CertificationType> CertificationTypes { get; set; } // CertificationTypes
        public System.Data.Entity.DbSet<Dog> Dogs { get; set; } // Dogs
        public System.Data.Entity.DbSet<EquipmentRestriction> EquipmentRestrictions { get; set; } // EquipmentRestrictions
        public System.Data.Entity.DbSet<Examiner> Examiners { get; set; } // Examiners
        public System.Data.Entity.DbSet<Handler> Handlers { get; set; } // Handlers
        public System.Data.Entity.DbSet<Question> Questions { get; set; } // Questions
        public System.Data.Entity.DbSet<Section> Sections { get; set; } // Sections
        public System.Data.Entity.DbSet<Test> Tests { get; set; } // Tests
        public System.Data.Entity.DbSet<TestResult> TestResults { get; set; } // TestResults
        public System.Data.Entity.DbSet<TestResultsAnswer> TestResultsAnswers { get; set; } // TestResultsAnswers
        public System.Data.Entity.DbSet<TestResultsSection> TestResultsSections { get; set; } // TestResultsSections

        static CanineProjDbContext()
        {
            System.Data.Entity.Database.SetInitializer<CanineProjDbContext>(null);
        }

        public CanineProjDbContext()
            : base("Name=ProjectCanine")
        {
        }

        public CanineProjDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public CanineProjDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public CanineProjDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public CanineProjDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CertificationTypeEfConfig());
            modelBuilder.Configurations.Add(new DogEfConfig());
            modelBuilder.Configurations.Add(new EquipmentRestrictionEfConfig());
            modelBuilder.Configurations.Add(new ExaminerEfConfig());
            modelBuilder.Configurations.Add(new HandlerEfConfig());
            modelBuilder.Configurations.Add(new QuestionEfConfig());
            modelBuilder.Configurations.Add(new SectionEfConfig());
            modelBuilder.Configurations.Add(new TestEfConfig());
            modelBuilder.Configurations.Add(new TestResultEfConfig());
            modelBuilder.Configurations.Add(new TestResultsAnswerEfConfig());
            modelBuilder.Configurations.Add(new TestResultsSectionEfConfig());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CertificationTypeEfConfig(schema));
            modelBuilder.Configurations.Add(new DogEfConfig(schema));
            modelBuilder.Configurations.Add(new EquipmentRestrictionEfConfig(schema));
            modelBuilder.Configurations.Add(new ExaminerEfConfig(schema));
            modelBuilder.Configurations.Add(new HandlerEfConfig(schema));
            modelBuilder.Configurations.Add(new QuestionEfConfig(schema));
            modelBuilder.Configurations.Add(new SectionEfConfig(schema));
            modelBuilder.Configurations.Add(new TestEfConfig(schema));
            modelBuilder.Configurations.Add(new TestResultEfConfig(schema));
            modelBuilder.Configurations.Add(new TestResultsAnswerEfConfig(schema));
            modelBuilder.Configurations.Add(new TestResultsSectionEfConfig(schema));
            return modelBuilder;
        }
    }
}
// </auto-generated>
