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
    public delegate int MyDelegate(int intValue);
    public int Method1(int intMethod1)
    {
        return intMethod1 * 2;
    }

    public int Method2(int intMethod2)
    {
        return intMethod2 * 10;
    }

    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        int result1 = myDelegate(10);
        System.Console.WriteLine(result1);
        myDelegate = new MyDelegate(Method2);
        int result2 = myDelegate(10);
        Sytem.Console.Writeline(result2);

    }
}

