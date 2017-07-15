namespace SchoolDiary.Api.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    using SchoolDiary.Data.Common;
    using SchoolDiary.Model;
    using SchoolDiary.Models;

    public class TimeTableDAL
    {
        private IDbRepository<TimeTable> timeTable;

        public TimeTableDAL(DbContext context)
        {
            this.timeTable = new DbRepository<TimeTable>(context);
        }

        public IEnumerable<TimeTableItemViewModel> GetTimeTableByGroup(int groupId)
        {
            return timeTable.All()
                .Where(x => x.GroupId == groupId)
                .Select(x => new TimeTableItemViewModel()
                {
                    Id = x.Id,
                    DayOfWeek = x.DayOfWeek,
                    OrderNumber = x.OrderNumber,
                    RoomNumber = x.RoomNumber,
                    Shift = x.Shift,
                    Group = x.Group.Name,
                    Discipline = x.Discipline.Name,
                    Teacher = x.Teacher.Name,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime
                }).ToList();
        }
    }
}