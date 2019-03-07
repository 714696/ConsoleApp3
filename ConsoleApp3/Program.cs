using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0714696_assignment2
{
    class Program
    {
        public static void Main()
        {
            //Student Name Manpreet Singh Student ID C0714696
            //CSD3354 Section 2
            //Assignment 2
            //March 6, 2019 
            //TO DO: Call Method2 from the DelegateExercises Class
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
        }
    }
}

public class DelegateExercises
{
    public delegate int MyDelegate();
   
    void Method1()
    {
        System.Console.WriteLine("MyDelegate");
    }

    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        myDelegate();


    }
}

