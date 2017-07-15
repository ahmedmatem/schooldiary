namespace SchoolDiary.Model
{
    using System;
    using SchoolDiary.Data.Common;

    public abstract class Person : BaseModel<int>, INameable
    {
        public string Name { get; set; }
    }
}
