namespace InputOutput;

    public class Person
    {
        public int Age { get; set; }
    }
interface IInputOutput
{
    public static string Name;
    public void Age()
    {
        Console.WriteLine("My age is: ");
    }
}


