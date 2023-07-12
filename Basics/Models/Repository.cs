namespace Basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>(){

                new Course(){Id=1, Title="ASPnet kursu", Description="Sifirdan ileri düzey", Image="ASP.jpg"},
                new Course(){Id=2, Title="Ruby On Rails kursu", Description="Sifirdan ileri düzey", Image="ruby.jpg"},
                new Course(){Id=3, Title="PHP kursu", Description="Sifirdan orta düzey", Image="php.jpg" }
            };
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course GetById(int id){
           return _courses.FirstOrDefault(c=> c.Id==id );
        }

    }
}