namespace SchoolDiary.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    using SchoolDiary.Model;

    // Models returned by TimeTableController actions.

    public class TimeTableItemViewModel
    {
        public int Id { get; set; }

        public Model.DayOfWeek DayOfWeek { get; set; }

        public int OrderNumber { get; set; }

        public string RoomNumber { get; set; }

        public Shift Shift { get; set; }

        public string Group { get; set; }

        public string Discipline { get; set; }

        public string Teacher { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }
    }
}