using System;

namespace ConsoleApp1
{
    //this is a delegate which gets turned into a class on MSIL level
    //seems just like a method definition 😶
    delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Delegates!");

            //look at the constructor here: It takes a method
            MyDelegate myDelegate = new MyDelegate(MyXMethod);

            //so you said it is a class on complier level but we are treating it as a method here? eh? 🙄
            //Yes! that is just a syntatic sugar where the complier actually calls myDelegate.Invoke()😁
            myDelegate();
            Console.WriteLine(myDelegate.Method);
            Console.WriteLine(myDelegate.Target);

            // myDelegate.Invoke(); -- this will work too!


        }

        static void MyXMethod() {

            Console.WriteLine("hello from MyXMethod");
        }

        void MyYMethod()
        {
            Console.WriteLine("hello from MyXMethod");
        }
    }
}
