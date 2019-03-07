using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0714696_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Name Manpreet Singh Student ID C0714696
            //CSD3354 Section 2
            //Assignment 2
            //March 6, 2019 
            //TO DO: Call Method2 from the DelegateExercises Class
            DelegateExercises a = new DelegateExercises();
            a.Method2();
        }
    }
}

public class DelegateExercises
{
    public delegate void MyDelegate();


    void Method1()
    {
        Console.WriteLine("Method1");
        Console.ReadLine();
    }

    public void Method2()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        myDelegate(50);

    }
}

