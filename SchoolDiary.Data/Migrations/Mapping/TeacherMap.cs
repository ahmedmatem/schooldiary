namespace SchoolDiary.Data.Migrations.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SchoolDiary.Model;

    public class TeacherMap : EntityTypeConfiguration<Teacher>
    {
        public TeacherMap()
        {
            this.HasOptional(x => x.Group)
                .WithOptionalPrincipal()
                .Map(x => x.MapKey("TeacherId"));
        }
    }
}
