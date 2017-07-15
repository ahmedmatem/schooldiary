namespace SchoolDiary.Model
{
    using SchoolDiary.Data.Common;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TimeTable")]
    public class TimeTable : BaseModel<int>
    {
        public DayOfWeek DayOfWeek { get; set; }

        public int OrderNumber { get; set; }

        public string RoomNumber { get; set; }

        public Shift Shift { get; set; }

        public int GroupId { get; set; }

        public int DisciplineId { get; set; }

        public int TeacherId { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        // Navigation properties

        public Group Group { get; set; }

        public Discipline Discipline { get; set; }

        public Teacher Teacher { get; set; }
    }
}
