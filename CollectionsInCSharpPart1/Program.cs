// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Array.Resize(ref arr, 15); //create a new array and the old array will be destory

            ArrayList al = new ArrayList(2);
            al.Add(100);
            Console.WriteLine(al.Capacity); //the value will double 
            al.Add(200); al.Add(300); al.Add(400);
            Console.WriteLine(al.Capacity);
            al.Add(500);
            Console.WriteLine(al.Capacity);

            foreach (object obj in al) //this will print all of the values
                Console.Write(obj + " ");
            Console.WriteLine();

            //if you want to add a value bween an array

            al.Insert(3, 350);
            foreach (object obj in al) //this will print all of the values
                Console.Write(obj + " ");
            Console.WriteLine();

            //al.Remove(200);
            al.RemoveAt(1);
            foreach (object obj in al) //this will print all of the 
                Console.Write(obj + " ");
            Console.WriteLine();

            Console.ReadLine();








        }
    }
}

/*
 * 3 things we cannot do for an Array:
 
 * Increasing the size 
 *  You can neer insert a value into the middle of the array
 *  we can nenver delete a value in the middle of the array


A collections is like an array and it is capable of storing multiple values, but has 3 functions. 
It can do all of these 3 things:
 * Increasing the size 
 *  You can neer insert a value into the middle of the array
 *  we can nenver delete a value in the middle of the array
 

These are available for collections.


Non-Generic Collections:
All of theses are classes which we are called collection classes.

These are available under Systems.Collections:
Stacks
Queue
LinkedList
SortedList
ArrayList
hastable

stack is not available, first you have to define and then consume. same for Queue

What is the difference between from Array and Arraylist:
Array - Fixed Length
Not possible to insert items
Not possible to delete items

ArrayList - Variable Length
We can insert items into the middle
We can delete items from the middle

start with 0 and then 4, 16, 18..etc. it will inrecement. 

 */