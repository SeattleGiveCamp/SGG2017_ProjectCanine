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
    public class FakeCanineProjDbContext : ICanineProjDbContext
    {
        public System.Data.Entity.DbSet<CertificationType> CertificationTypes { get; set; }
        public System.Data.Entity.DbSet<Dog> Dogs { get; set; }
        public System.Data.Entity.DbSet<EquipmentRestriction> EquipmentRestrictions { get; set; }
        public System.Data.Entity.DbSet<Examiner> Examiners { get; set; }
        public System.Data.Entity.DbSet<Handler> Handlers { get; set; }
        public System.Data.Entity.DbSet<OtherRestriction> OtherRestrictions { get; set; }
        public System.Data.Entity.DbSet<Question> Questions { get; set; }
        public System.Data.Entity.DbSet<Test> Tests { get; set; }
        public System.Data.Entity.DbSet<TestResult> TestResults { get; set; }
        public System.Data.Entity.DbSet<TestResultsAnswer> TestResultsAnswers { get; set; }

        public FakeCanineProjDbContext()
        {
            CertificationTypes = new FakeDbSet<CertificationType>("Id");
            Dogs = new FakeDbSet<Dog>("Id");
            EquipmentRestrictions = new FakeDbSet<EquipmentRestriction>("Id");
            Examiners = new FakeDbSet<Examiner>("Id");
            Handlers = new FakeDbSet<Handler>("Id");
            OtherRestrictions = new FakeDbSet<OtherRestriction>("Id");
            Questions = new FakeDbSet<Question>("Id");
            Tests = new FakeDbSet<Test>("Id");
            TestResults = new FakeDbSet<TestResult>("Id");
            TestResultsAnswers = new FakeDbSet<TestResultsAnswer>("Id");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
// </auto-generated>