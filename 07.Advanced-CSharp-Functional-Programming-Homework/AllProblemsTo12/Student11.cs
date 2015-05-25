namespace AllProblemsTo12
{
    class Student11 : Student
    {
        public string GroupName { get; set; }

        public Student11(Student student, string groupName)
            : base(student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.Phone, student.Email, student.Marks, student.GroupNumber)
        {
            GroupName = groupName;
        }
    }
}
