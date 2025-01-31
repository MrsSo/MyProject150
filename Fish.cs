using System.Diagnostics;

[DebuggerDisplay($"{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Fish : Animal 
{
    public Fish(string name, int age) : base(name, age) 
    {
    }

    private static object GetDebuggerDisplay()
    {
        throw new NotImplementedException();
    }

    public override void MakeSound()
    {
        //Fish don't make sounds in the same way birds do, but for the sake of example:
        Console.WriteLine($"{Name} bubbles.");
    }

    
}
    