namespace SchoolDiary.Data
{
    using System;
    using System.Linq;
    using System.Data.Entity;

    using Microsoft.AspNet.Identity.EntityFramework;

    using SchoolDiary.Model;
    using SchoolDiary.Data.Common;
    using SchoolDiary.Data.Migrations.Mapping;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Teacher> Teachers { get; set; }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Discipline> Disciplines { get; set; }

        public IDbSet<Group> Groupes { get; set; }

        public IDbSet<TimeTable> TimeTable { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new TeacherMap());
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }
}
