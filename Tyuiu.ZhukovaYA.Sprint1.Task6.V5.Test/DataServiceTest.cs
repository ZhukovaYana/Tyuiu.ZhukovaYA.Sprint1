using Tyuiu.ZhukovaYA.Sprint1.Task6.V5.Lib; 
 
namespace Tyuiu.ZhukovaYA.Sprint1.Task6.V5.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        string res = ds.CheckSymmetricalWords("оно она казак шаман шалаш");
        Assert.AreEqual(res, "оно, казак, шалаш");
   } 
} 
