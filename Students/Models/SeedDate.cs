namespace Students.Models
{
    public static class SeedData
    {
        public static List<Student> Students { get; }

        static SeedData()
        {
            Students = new List<Student>
            {
                new Student
                {
                    Group = "Group A",
                    Id = 1,
                    Fullname = "John Doe",
                    Diemdanh = "Active",
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Thumbnail = "https://via.placeholder.com/50"
                },
                new Student
                {
                     Group = "Group A",
                    Id = 1,
                    Fullname = "John Doe",
                    Diemdanh = "Active",
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Thumbnail = "https://via.placeholder.com/50"
                },
                // Add more objects for additional students
            };
        }
    }

}
