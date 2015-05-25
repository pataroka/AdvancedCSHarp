namespace AllProblemsTo12
{
    class StudentSpecialty
    {
        public string Specialty { get; set; }
        public int FacultyNumber { get; set; }

        public StudentSpecialty (string specialty, int facultyNumber)
        {
            Specialty = specialty;
            FacultyNumber = facultyNumber;
        }
    }
}
