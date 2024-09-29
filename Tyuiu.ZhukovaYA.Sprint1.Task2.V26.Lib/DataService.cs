using tyuiu.cources.programming.interfaces.Sprint1; 
 
namespace Tyuiu.ZhukovaYA.Sprint1.Task2.V26.Lib;

public class DataService : ISprint1Task2V26
{
    public int Calculate(double value, int valueTwo)
    {
        return ((int)value * 60) + valueTwo;
    }
} 
