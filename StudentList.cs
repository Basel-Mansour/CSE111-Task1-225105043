// Name:Basel Mohamed Mansour Elmorsy
// Student ID:225105043
namespace Cse111Task1
{
    public class StudentList
    {
        public Student? First { get; set; }
        public Student? Last { get; set; }
        public int Count { get; private set; }
        public StudentList()
        {
            First = null;
            Last = null;
            Count = 0;
        }
        public void AddFront(int id)
        {
            Student newStudent = new Student(id);

            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                newStudent.Next = First;
                First = newStudent;
            }

            Count++;
        }
        public void AddEnd(int id)
        {
            Student newStudent = new Student(id);
            if (Last == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                Last.Next = newStudent;
                Last = newStudent;
            }
            Count++;
        }
        public bool Remove(int id)
        {
            if (First == null)
            {
                return false;
            }

            if (First.Id == id)
            {
                First = First.Next;
                Count--;

                if (First == null)
                {
                    Last = null;
                }

                return true;
            }

            Student current = First;

            while (current.Next != null)
            {
                if (current.Next.Id == id)
                {
                    Student removed = current.Next;

                    current.Next = removed.Next;

                    if (removed == Last)
                    {
                        Last = current;
                    }

                    Count--;

                    return true;
                }

                current = current.Next;
            }

            return false;
        }
        public void Reverse()
        {
            Student? previous = null;
            Student? current = First;
            Student? next = null;

            Last = First;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;

                previous = current;
                current = next;
            }

            First = previous;
        }
        public void Print()
        {
            Student? current = First;

            while (current != null)
            {
                Console.Write(current.Id);

                if (current.Next != null)
                {
                    Console.Write(" ");
                }

                current = current.Next;
            }

            Console.WriteLine();
        }
   
}

}