using Tyuiu.ZhukovaYA.Sprint1.Task7.V18.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint1.Task7.V18.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        double res = ds.Calculate(0, 0);
        Assert.AreEqual(res, 0.5);
   } 
} 
