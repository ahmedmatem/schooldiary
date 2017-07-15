namespace SchoolDiary.Model
{
    using SchoolDiary.Data.Common;

    public class Group : BaseModel<int>
    {
        public string Name { get; set; }

        // Navigation properties
        public virtual Teacher Teacher { get; set; }
    }
}
