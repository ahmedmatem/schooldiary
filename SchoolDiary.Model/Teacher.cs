namespace SchoolDiary.Model
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Teacher : Person
    {

        // Navigation properties
        public virtual Group Group { get; set; }
    }
}
