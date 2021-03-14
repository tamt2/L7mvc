namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-tamt2-dykstra2] - definition for Grade?
    //tinfo200:[2021-03-13-tamt2-dykstra2] - student will have a grade eventually, grade? is nullable
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        //tinfo200:[2021-03-13-tamt2-dykstra2] - input the information of each student
        //tinfo200:[2021-03-13-tamt2-dykstra2] - creating each ID property
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        //tinfo200:[2021-03-13-tamt2-dykstra2] - Grade is numerator type
        public Grade? Grade { get; set; }

        public Student Student { get; set; }
    }
}