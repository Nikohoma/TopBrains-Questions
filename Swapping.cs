using System;
using System.Collections.Generic;
using System.Text;

namespace Swapping
{
    public class Swapping
    {
        /// <summary>
        /// Method to swap by ref method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapWithRef(ref int a, ref int b)
        {
            Console.WriteLine("\n Swapping with Ref : ");
            Console.WriteLine($"\nBefore Swap: x = {a} , y = {b}");
            (a, b) = (b, a);
            Console.WriteLine($"\nAfter Swap: x = {a} , y = {b}");
            
        }

        /// <summary>
        /// Method to swap by out method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapWithOut(int A, int B, out int a, out int b)
        {
            Console.WriteLine("\nSwapping with out : ");
            Console.WriteLine($"\nBefore Swap : x = {A} , y = {B}");
            a = B; b = A;
            Console.WriteLine($"\nAfter Swap : x = {a} , y = {b}");


        }

    }

    /// <summary>
    /// Main Class
    /// </summary>
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Swapping s = new Swapping();
            int x = 2; int y = 3;
            s.SwapWithRef(ref x, ref y); 
            s.SwapWithOut(x,y,out x, out y); // x = 3 , y = 2 (from ref swap)

        }
    }
}
