// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Array.Resize(ref arr, 15); //create a new array and the old array will be destory
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



 */