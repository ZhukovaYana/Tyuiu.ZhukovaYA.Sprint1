using Tyuiu.ZhukovaYA.Sprint1.Task3.V13.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint1.Task3.V13.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        double res = ds.MultiplyOfDigits(123);
        Assert.AreEqual(res, 6);
    } 
} 
