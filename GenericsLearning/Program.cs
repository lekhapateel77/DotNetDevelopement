using System;
using System.Collections.Generic;

namespace GenericsLearning
{
    class Program
    {
        static void Main(string[] args)
        {
             Queue<Employee> line = new Queue<Employee>();

             Stack<Employee> line1 = new Stack<Employee>();

            Console.WriteLine("Queue is First In First OUT(FIFO)");
            line.Enqueue(new Employee { Name = "Alex" });
            line.Enqueue(new Employee { Name = "Scott" });

            while (line.Count > 0)
            {
                var employee = line.Dequeue();
                Console.WriteLine(employee.Name);
            }

            Console.WriteLine("Stack is Last In First Out(LIFO)");
            line1.Push(new Employee { Name = "Alex" });
            line1.Push(new Employee { Name = "Scott" });

            while (line1.Count > 0)
            {
                var employee = line1.Pop();
                Console.WriteLine(employee.Name);        
            }

        

            //HashSet Helps to avoid duplicates
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(2);
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            LinkedList<int> integers = new LinkedList<int>();
            integers.AddFirst(55);
            integers.AddFirst(65);
            var first = integers.First;
            integers.AddAfter(first,75);
            integers.AddBefore(first,85);


            foreach(var item in integers)
            {
                Console.WriteLine(item);
            }

            ////creating array of class employee
            //Employee[] employees = new Employee[] 
            //{
            //    new Employee{Name ="scott"},
            //    new Employee{ Name ="Alex"}
            //};

            //foreach(var employee in employees)
            //{
            //    Console.WriteLine(employee.Name);
            //}

            //for (int i =0;i< employees.Length;i++)
            //{
            //    Console.WriteLine(employees[i].Name);

            // }
            //Inoreder to increase array we need to resixe which may cause performance issues
            // Array.Resize(ref employees,10);

            //var numbers =new List<int>();
            //var capacity = -1;
            //while (true)
            //{
            //    if (numbers.Capacity != capacity)
            //    {
            //        capacity = numbers.Capacity;
            //        Console.WriteLine(capacity);

            //    }
            //    numbers.Add(1);
            //}


        }
    }
}
