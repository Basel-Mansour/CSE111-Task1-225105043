namespace Cse111Task1
{
    public class Student
    {

        public int Id { get; }
        public Student? Next { get; set; }
        public Student(int iD)
        {
            this.Id = iD;
            Next = null;
        }
    }

}