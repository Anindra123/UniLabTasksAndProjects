using System;
using System.Collections;

namespace GenericsAndCollectionDemo
{
    class Demo<T>
    {
        T val;
        public T Val
        {
            get { return val; }
            set { val = value; }
        }

    }
    class Program
    {
        static void GenFunc<T>(T val)
        {
            Console.WriteLine(val);
        }
        static void printElements(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void printQ(Queue q)
        {
            foreach (var item in q)
            {
                if (item.GetType().FullName == "System.Collections.Hashtable")
                {
                    var i = (Hashtable)item;
                    foreach (DictionaryEntry e in i)
                    {
                        Console.WriteLine(e.Key + " : " + e.Value);
                    }
                }
                else
                {
                    Console.WriteLine(item);
                }

            }
        }
        static void Main(string[] args)
        {
            //Demo<string> demo = new Demo<string>();
            //demo.Val = "hello";
            //Console.WriteLine(demo.Val);
            //Demo<int> demo1 = new Demo<int>();
            //demo1.Val = 1;
            //Console.WriteLine(demo1.Val);
            //GenFunc<string>("Hello");
            //GenFunc<double>(55.5);
            //ArrayList list = new ArrayList() { 1, "hello", 55.5 };
            //list.Add("World");
            //list.Add(false);
            //Console.WriteLine("ArrayList Count :" + list.Count);
            //Console.WriteLine("ArrayList Capacity:" + list.Capacity);
            //printElements(list);
            //list.Remove(false);
            //Console.WriteLine("After removing......");
            //printElements(list);
            //int a = (int)list[0];
            //string b = (string)list[1];
            //ArrayList list2 = new ArrayList() { 7, "James Bond" };
            //list2.Add(a);
            //list2.Add(b);
            //list.AddRange(list2);
            //Console.WriteLine("After combining two arraylist......");
            //printElements(list);
            //Console.WriteLine("Searching element James Bond :"
            //    + list.Contains("James Bond"));
            //Console.WriteLine("Searching element false : "
            //    + list.Contains(false));

            //Hashtable ht = new Hashtable();
            //ht.Add("20-41848-1", "Anindra Das Bivas");
            //ht.Add(101, 55.8);
            //ht.Add("H", 1001);
            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key + " : " + item.Value);
            //}
            //ht.Remove("H");
            //Console.WriteLine("After removing .......");
            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key + " : " + item.Value);
            //}
            //Console.WriteLine("Hastable contains key H : "
            //    + ht.Contains("H"));
            //Console.WriteLine("Hastable contains key 101 : " +
            //    ht.Contains(101));
            //Console.WriteLine("Hastable contains key value 55.8 : " +
            //    ht.ContainsValue(55.8));
            //Queue q = new Queue();
            //q.Enqueue(1);
            //q.Enqueue("abc");
            //q.Enqueue(false);
            //q.Enqueue(ht);
            //q.Enqueue(55.9);
            //printQ(q);
            //var p = q.Peek();
            //Console.WriteLine("Peeked element :" + p);
            //var o = q.Dequeue();
            //Console.WriteLine("Dequed element :" + o);
            //printQ(q);
            Stack s = new Stack();
            s.Push("a");
            s.Push(1);
            s.Push(false);
            s.Push(55.8);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            var p = s.Pop();
            Console.WriteLine("Popped value :" + p);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            var pe = s.Peek();
            Console.WriteLine("Peeked value :" + pe);


            Console.ReadKey();
        }
    }
}
