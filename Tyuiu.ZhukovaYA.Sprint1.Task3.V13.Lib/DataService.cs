using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZhukovaYA.Sprint1.Task3.V13.Lib;

public class DataService : ISprint1Task3V13
{
    public double MultiplyOfDigits(double number)
    {
        double multiplication = 1;

        for (int i = 0; i < 3; i++)
        {
            multiplication *= (int)number % 10;
            number = (int)(number / 10);
        }

        return multiplication;
    }
} 
