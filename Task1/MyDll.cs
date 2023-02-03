namespace Task1;
public class MyDll
{
    /// <summary>
    /// Gamma(x,y,z)
    /// </summary>
    /// <param name="x" double></param>
    /// <param name="y" double></param>
    /// <param name="z" double></param>
    /// <returns>Повертає значення виразу |x^y/x - cbrt(y/x)|</returns>
    ///

    public static double Gamma(double x, double y, double z)
    {
        double gamma = Math.Abs(Math.Pow(x, (y / x)) - Math.Cbrt(y / x));
        return gamma;
    }

    /// <summary>
    /// Beta
    /// </summary>
    /// <param name="x" double></param>
    /// <param name="y" double></param>
    /// <param name="z" double></param>
    /// <returns>Повертає значення виразу (y-z)*((y-z)/(y-x))/1+ (y-x)^2</returns>
    public static double Beta(double x, double y, double z)
    {
        double beta = (y - x) * ((y - z / (y - x)) / (1 + Math.Pow((y - z), 2)));
        return beta;
    }
}