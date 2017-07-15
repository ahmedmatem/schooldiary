namespace SchoolDiary.Data.Migrations.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SchoolDiary.Model;

    public class GroupMap : EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            this.HasOptional(x => x.Teacher)
                .WithOptionalPrincipal()
                .Map(x => x.MapKey("GroupId"));
        }
    }
}
