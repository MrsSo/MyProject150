namespace Exam1;

public class LargestNumberFinder
{
    public interface INumberProgram
    {
        System.String NumberProgram1 { get; set; }

        static abstract global::System.Int32 ProcessInput(global::System.String input, ref global::System.Int32 largest);
    }

    public class NumberProgram : INumberProgram
    {
        static void Main(string[] args)
        {
            int largest = 5;
            int result = NumberProgram1("10", ref largest);
            Assert.AreEqual(10, largest);
            Assert.AreEqual(10, result);
        }
    }

    public class NumberProgram
    {
        Console.WriteLine('Enter largest NumberProgram');
        Console.WriteLine("5", + LargestNumberFinder);
        string NumberProgram = Console.ReadLine();
        public System.String NumberProgram1 { get => NumberProgram; set => NumberProgram = value; }
    }
   
    public class NumberProgram
    {
        public static int ProcessInput(string input, ref int largest)
        {
            int largest = 20;
            int result = NumberProgram.ProcessInput("40", ref largest);
            global::System.Object value = Assert.AreEqual(20, largest);
            global::System.Object value1 = Assert.AreEqual(10, result);
        }

    }
}
