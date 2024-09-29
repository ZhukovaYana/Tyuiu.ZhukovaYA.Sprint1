using Tyuiu.ZhukovaYA.Sprint1.Task2.V26.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint1.Task2.V26.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        int res = ds.CalculateMinutesSinceStart(1, 10);
        Assert.AreEqual(res, 70);
    } 
} 
