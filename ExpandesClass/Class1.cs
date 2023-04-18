using System.Text.RegularExpressions;
using System.Dynamic;


namespace ExpandesClass
{
    public class Lesson
    {
        public Lesson(Discipline discipline, Employee employee, Group group, Pair pair, LessonType lessonType)
        {
            Discipline = discipline;
            Employee = employee;
            Group = group;
            Pair = pair;
            LessonType = lessonType;
        }

        public Discipline Discipline { get; set; }
        public Employee Employee { get; set; }
        public Group Group { get; set; }
        public Pair Pair { get; set; }
        public LessonType LessonType { get; set; }

        public dynamic ToExpando()
        {
            dynamic expando = new ExpandoObject();

            expando.Discipline = Discipline.ToExpando();
            expando.Employee = Employee.ToExpando();
            expando.Group = Group.ToExpando();
            expando.Pair = Pair.ToExpando();
            expando.LessonType = LessonType.ToExpando();

            return expando;
        }
    }
}
