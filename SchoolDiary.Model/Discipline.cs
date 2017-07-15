namespace SchoolDiary.Model
{
    using SchoolDiary.Data.Common;

    public class Discipline : BaseModel<int>
    {
        public string Name { get; set; }

        public string ShortName { get; set; }
    }
}
