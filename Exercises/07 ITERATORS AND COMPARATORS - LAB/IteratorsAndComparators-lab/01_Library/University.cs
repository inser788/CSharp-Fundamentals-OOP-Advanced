using System.Collections;
using System.Collections.Generic;

public class University : IEnumerable<Student>
{
    private readonly List<Student> students;

    public University()
    {
        this.students=new List<Student>();
    }

    public void AddStudent(Student student)
    {
        this.students.Add(student);
    }

    public IEnumerator<Student> GetEnumerator()
    {
       // return new UniIterator(this.students);
        for (int i = 0; i < this.students.Count; i+=2)
        {
            yield return this.students[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class UniIterator:IEnumerator<Student>
    {
        private int currentIndex;

        private readonly IList<Student> students;

        public UniIterator(IList<Student> students)
        {
            this.Reset();
            this.students = students;
        }

        public bool MoveNext()
        {
            return (currentIndex += 2) < this.students.Count;
        }

        public void Reset()
        {
            this.currentIndex = -2;
        }

        public Student Current => this.students[currentIndex];

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
        }
    }
}

