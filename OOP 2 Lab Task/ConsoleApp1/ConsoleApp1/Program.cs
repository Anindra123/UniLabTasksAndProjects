using System;
using System.Collections;

namespace ConsoleApp1
{
    public delegate void del(int a);

    class GenericDemo<T>
    {

        private T s1;
        //private double  s2; // two feild variable of different type need to 
        //                    // assign different get set
        //                    // work doing is same
        public T S1Prop
        {
            get { return s1; }
            set { s1 = value; }
        }

    }
    class Students
    {
        //string []name = new string[5]; // cannot get set for multiple values
        //solution use an indexer
        string[] name = new string[5];
        public string this[int i]
        {
            get
            {
                return name[i];
            }
            set
            {
                name[i] = value;
            }
        }
        public string this[string s] // can be overload indexers
        {
            get
            {
                for (int i = 0; i < 5; i++)
                {
                    if (s.Equals(name[i]))
                    {
                        return "Found";
                    }
                }
                return "Not found";
            }
        }

    }
    class Program
    {


        static void Main(string[] args)
        {
            //GenericDemo<string> gd = new GenericDemo<string>();
            //gd.S1Prop = "Hello"; // generic class makes the members of the class
            //Console.WriteLine(gd.S1Prop);               // independent of any type 
            //Students s = new Students();
            //s[0] = "John"; // class object is behaving like an array
            //s[1] = "Bob";
            //s[2] = "Sue";
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}
            //Console.WriteLine(s["Bob"]);
            //Console.WriteLine(gd.S1Prop);
            //ArrayList a = new ArrayList();
            //ArrayList a2 = new ArrayList();
            //a.Add(1);
            //a.Add("A");
            //a.Add('c');
            //a.Add('c');
            //a.Add(5.5);
            //foreach (var i in a)
            //{
            //    Console.WriteLine(i);
            //}
            //a2.Add(false);
            //a2.Add(1.0F);
            //a.AddRange(a2);
            //Console.WriteLine();
            //a.Remove('c');
            //a.Insert(2, 'f');
            ////a[2] = 'j';
            //foreach (var i in a)
            //{
            //    Console.WriteLine(i);
            //}
            //if (a.Contains('c'))
            //{
            //    Console.WriteLine("Found");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");

            //}
            //Console.WriteLine();
            ////number of elements
            //Console.WriteLine(a.Count);
            ////size of the array list
            //Console.WriteLine(a.Capacity);
            //Stack s = new Stack();
            //s.Push("A");
            //s.Push(1);
            //s.Push(2);
            //s.Pop();
            //s.Push('c');
            //s.Pop();
            ////A 
            ////A 1
            ////A 1 2
            ////A 1
            ////A 1 c
            ////A 1
            ////1
            ////A
            //var a = s.Peek();
            //foreach (var i in s)
            //{
            //    Console.WriteLine(i);
            //}
            //Queue q = new Queue();

            //Console.Write(a);
            ////c
            ////flase
            ////2.2
            //q.Enqueue("a");
            //q.Enqueue(5);
            //q.Enqueue('c');
            //q.Dequeue();
            //q.Enqueue(false);
            //q.Dequeue();
            //q.Enqueue(2.2);

            //foreach (var i in q)
            //{
            //    Console.WriteLine(i);
            //}
            ////Console.WriteLine();
            Hashtable h = new Hashtable();
            //key and value
            h.Add("C", 1);
            h.Add(7, "bond");
            h.Add(5, 2);
            //keys must be unique or else exception
            //h.Add(5, "A");
            //need to print key value pair
            foreach (DictionaryEntry e in h)
            {
                Console.WriteLine(e.Key + " " + e.Value);
            }
            Console.WriteLine(h[7]);
            if (h.Contains(5))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");

            }
            //simple delegate
            //no paraenthesis at the time of assigning a method as 
            //reference

            //del d = method1; // need to assign it evertime like a field variable
            //d(2); 
            //d = method2;
            //d(10);
            //d = method3;
            //d(40);
            ////cannot assign method 4 as signature doesn't match
            ////d = method4;

            //del d2 = method3;
            //d2 += method1;
            //d2 += method2;
            //d2(50); // can only assign a single variable
            //PassM(method3, 5); // passing method as parameter
            //PassM(method1, 2);
            //PassM(method2, 4);

            Console.ReadKey();
        }

        static void PassM(del d, int s)
        {
            d(s);
        }
    }
}
