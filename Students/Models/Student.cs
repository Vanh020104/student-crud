namespace Students.Models
{
    public class Student
    {
        public string Group { get; set; }
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Diemdanh { get; set; }
        public string Comment { get; set; }
        public string Thumbnail { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
