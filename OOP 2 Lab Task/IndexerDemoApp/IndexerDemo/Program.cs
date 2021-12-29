using System;

namespace IndexerDemo
{
    class SampleCollection<T>
    {
        private T[] arr = new T[3];

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
    class Students
    {
        string[] arrOfStudents = new string[3];
        public string this[int i]
        {
            get { return arrOfStudents[i]; }
            set { arrOfStudents[i] = value; }
        }
        public string this[string name]
        {
            get
            {
                for (int i = 0; i < arrOfStudents.Length; i++)
                {
                    if (name == arrOfStudents[i])
                    {
                        return arrOfStudents[i].ToUpper();
                    }
                }
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students[0] = "Joe Smith";
            students[1] = "Sue Storm";
            students[2] = "Bob Smith";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(students[i]);
            }
            Console.WriteLine(students["Bob Smith"]);
            Console.ReadKey();
        }
    }
}
