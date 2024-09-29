using Tyuiu.ZhukovaYA.Sprint1.Task5.V3.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint1.Task5.V3.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        int res = ds.Calculate(130985);
        Assert.AreEqual(res, 9);
   } 
} 
