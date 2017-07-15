namespace SchoolDiary.Controllers
{
    using SchoolDiary.Data;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class BaseController : Controller
    {
        protected DbContext context;

        public BaseController()
        {
            this.context = ApplicationDbContext.Create();
        }
    }
}