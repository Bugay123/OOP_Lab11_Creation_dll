namespace ConsoleTask1;
class Program
{
    /// <summary>
    /// Використання методів Gamma() та Beta() з бібліотеки MyDll
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        double x = 1.825;
        double y = 18.225;
        double z = -3.298;

        double myGamma = Task1.MyDll.Gamma(x, y, z);
        Console.WriteLine(myGamma);
        double myBeta = Task1.MyDll.Beta(x, y, z);
        Console.WriteLine(myBeta);
    }
}

