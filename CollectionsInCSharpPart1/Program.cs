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

            //When you pass a parameter then the initial capacity will start at that number. 

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

            //If you want to add a value between an array you can use the Insert

            al.Insert(3, 350);
            foreach (object obj in al) //this will print all of the values
                Console.Write(obj + " ");
            Console.WriteLine();

            //If you want to remova a value yu can use Remove. Or you can remove using the RemoveAt()

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
 Collections:

-Dynamics Array

int[] array = new int[10];

Array.Resize
 
 * 3 things we cannot do for an Array:
 
 * Increasing the size 
 *  You can neer insert a value into the middle of the array
 *  we can never delete a value in the middle of the array


A collections is like an array and it is capable of storing multiple values, but has 3 functions. These are available for collections.
It can do all of these 3 things:
 * Increasing the size 
 *  You can never insert a value into the middle of the array
 *  We can nenver delete a value in the middle of the array
 




Non-Generic Collections:
All of theses are classes which we are called collection classes.

These are available under Systems.Collections:
Stacks
Queue
LinkedList
SortedList
ArrayList
hastable

Stack is not available, first you have to define and then consume. 
Queue is not available, first you have to define and then consume.

What is the difference between Array and Arraylist?
Array - Fixed Length
Not possible to insert items
Not possible to delete items

ArrayList - Variable Length
We can insert items into the middle
We can delete items from the middle

Start with 0 and then 4, 16, 18..etc. it can auto resize.  

 */