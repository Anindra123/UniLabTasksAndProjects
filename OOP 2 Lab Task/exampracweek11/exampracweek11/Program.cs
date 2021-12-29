using System;
using System.Collections.Generic;

namespace exampracweek11
{
    class Student
    {
        public int Student_ID { get; set; }
        public string Student_Name { get; set; }
        public double CGPA { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> name = new List<string>();
            //name.Add("John");
            //name.Add("Bob");
            //name.Add("Sue");
            //foreach (string item in name)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(name.Count);
            //Console.WriteLine(name.Capacity);
            //name.Remove("Sue");
            //name.Insert(0, "Joe");
            //foreach (string item in name)
            //{
            //    Console.WriteLine(item);
            //}
            //name[0] = "Joe Mama";
            //foreach (string item in name)
            //{
            //    Console.WriteLine(item);
            //}
            //List<Student> students = new List<Student>()
            //{
            //    new Student() {Student_ID = 10,Student_Name = "Sue",CGPA = 3.00},
            //    new Student() {Student_ID = 12,Student_Name = "Bob",CGPA = 3.5},
            //    new Student() {Student_ID = 15,Student_Name = "John",CGPA = 3.90}

            //};
            //foreach (var item in students)
            //{
            //    Console.WriteLine($"Name :{item.Student_Name} , ID : {item.Student_ID}, CGPA : {item.CGPA}");
            //}
            //students.Remove(students[2]);
            //Student s1 = new Student();
            //s1.Student_Name = "Jack";
            //s1.Student_ID = 20;
            //s1.CGPA = 3.55;
            //Student s2 = new Student()
            //{
            //    Student_Name = "West",
            //    Student_ID = 25,
            //    CGPA = 4.00
            //};
            //students.Add(s1);
            //students.Add(s2);

            //foreach (var item in students)
            //{
            //    Console.WriteLine($"Name :{item.Student_Name} , ID : {item.Student_ID}, CGPA : {item.CGPA}");
            //}
            //Console.WriteLine(students.Contains(s1));
            //SortedList<string, string> slist = new SortedList<string, string>();
            //slist.Add("txt", "notepad.exe");
            //slist.Add("bmp", "paint.exe");
            //slist.Add("dib", "paint.exe");
            //slist.Add("rtf", "wordpad.exe");
            ////Cannot add a key value pair in sorted list which already exist
            ////throws argument exception
            //try
            //{
            //    slist.Add("txt", "word.exe");
            //}
            //catch
            //{
            //    Console.WriteLine("Key already exist");
            //}
            ////can get value through indexing the key
            //Console.WriteLine(slist["rtf"]);
            //slist["rtf"] = "word.exe";
            //Console.WriteLine(slist["rtf"]);
            ////adding a new value with key
            //slist["pdf"] = "foxit.exe";
            ////to print each value in sorted list
            //foreach (KeyValuePair<string, string> item in slist)
            //{
            //    Console.WriteLine(item.Key + ":" + item.Value);
            //}
            SortedList<int, string> students = new SortedList<int, string>();
            students.Add(9, "John");
            students.Add(2, "Bob");
            students.Add(5, "Sue");
            students.Add(1, "Jack");
            //to show it is sorted
            //sorts by key
            foreach (KeyValuePair<int, string> item in students)
            {
                Console.WriteLine(item);
            }
            //keys not in the list
            //throws keys not found exception
            //Console.WriteLine(students[10]);
            //use try get value
            string s = "";
            if (students.TryGetValue(10, out s))
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Key doesn't exist in the sorted list");

            }
            //can be done with contains key
            if (!students.ContainsKey(10))
            {
                students.Add(10, "Tim");
                Console.WriteLine(students[10]);
            }
            ////Remove takes a key as parameter and removes both key and value
            //students.Remove(1);
            //Console.WriteLine(students
            //    .ContainsValue("Jack"));
            //foreach (KeyValuePair<int, string> item in students)
            //{
            //    Console.WriteLine(item);
            //}
            ////to print only keys
            //IList<int> id = students.Keys;
            //foreach (int item in id)
            //{
            //    Console.WriteLine(item);
            //}
            ////to print only values 
            //IList<string> name = students.Values;
            //foreach (string item in name)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(students.Values[2]); // sue
            SortedList<string, string> slist3 = new SortedList<string, string>();
            slist3.Add("azb", "val1");
            slist3.Add("aab", "val4");
            slist3.Add("gam", "val5");
            slist3.Add("gak", "val6");
            // val4, val1, val6, val5
            //if some character matches sorts against the next character on the string
            foreach (KeyValuePair<string, string> item in slist3)
            {
                Console.WriteLine(item);
            }

            //Stack<int> s = new Stack<int>();
            ////s.Push("hello"); //generic stack is strongly type we cannot add string object
            //s.Push(5);
            //s.Push(10);
            //s.Push(20);
            //s.Pop();
            //s.Push(8);
            ////8
            ////10
            ////5
            //foreach (int item in s)
            //{
            //    Console.WriteLine(item);
            //}
            ////8
            //Console.WriteLine(s.Peek());
            Queue<string> q = new Queue<string>();
            q.Enqueue("Joe");
            q.Enqueue("Sue");
            q.Enqueue("Jack");
            //q.Dequeue();
            //q.Enqueue("Bob");
            ////Jack->Sue->Joe
            ////Jack->Sue
            ////Bob->Jack->Sue
            foreach (string item in q)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(q.Peek());
            Console.ReadKey();
        }
    }
}
