namespace SchoolDiary.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using SchoolDiary.Data.Common;
    using SchoolDiary.Model;
    using SchoolDiary.Api.DAL;
    using SchoolDiary.Models;

    [Authorize]
    public class TimeTableController : BaseController
    {
        private TimeTableDAL timeTableDAL;

        public TimeTableController()
        {
            this.timeTableDAL = new TimeTableDAL(this.context);
        }

        // GET: TimeTable
        public ActionResult Index()
        {

            return View();
        }

        // GET: TimeTable/index/groupId
        public ActionResult Index(int groupId)
        {
            List<TimeTableItemViewModel> groupTimeTable =
                (List<TimeTableItemViewModel>)timeTableDAL.GetTimeTableByGroup(groupId);

            return View(groupTimeTable);
        }
    }
}