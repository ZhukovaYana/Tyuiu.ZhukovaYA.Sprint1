using Tyuiu.ZhukovaYA.Sprint1.Task1.V21.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint1.Task1.V21.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        var x = 1;
        var y = 2;
        DataService ds = new DataService();
        var res = ds.Calculate(x, y);
        Assert.AreEqual(res, 0.4);
    } 
} 
