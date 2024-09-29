using tyuiu.cources.programming.interfaces.Sprint1; 
 
namespace Tyuiu.ZhukovaYA.Sprint1.Task5.V3.Lib;

public class DataService : ISprint1Task5V3
{
    public int Calculate(int k)
    {
        return Convert.ToInt32(k.ToString().Substring(k.ToString().Length-3,1));
    }
} 
