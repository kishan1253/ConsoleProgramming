using InputOutput;
using System;
using System.Numerics;

List <int> numbers=new List<int> ();
numbers.Add (15); //Adds element to list
numbers.Add (1);
numbers.Add (2);
numbers.Add (3);
foreach (var i in numbers)
{
    Console.WriteLine (i);
}
Console.WriteLine (numbers.Count);  //Gives size of list

numbers.Sort (); //Sorts the elements

numbers.Remove (15);  //Removes first occurence of the given item

numbers.Clear (); //Clears entire list

numbers.Contains (1); //Checks if the given item present in the list or not

Console.WriteLine(numbers.Max()); //Returns max value from the list

Console.WriteLine(numbers.Min()); //Returns min value from the list

numbers.IndexOf(3);  //Returns index of the item

numbers.EnsureCapacity (30);  //Ensures that the capacity of list matches given value

numbers.Reverse(); //Reverses the order of elements inside list

Person p1 = new();
p1.Age = 20;
Console.WriteLine (p1.Age);