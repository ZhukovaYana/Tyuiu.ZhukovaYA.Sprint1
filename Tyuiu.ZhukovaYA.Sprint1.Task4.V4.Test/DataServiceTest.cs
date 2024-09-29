using Tyuiu.ZhukovaYA.Sprint1.Task4.V4.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint1.Task4.V4.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        double res = ds.Calculate(1,1);
        Assert.AreEqual(res, 0.667);
   } 
} 
