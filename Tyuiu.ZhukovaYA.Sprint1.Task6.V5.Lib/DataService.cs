using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint1; 
 
namespace Tyuiu.ZhukovaYA.Sprint1.Task6.V5.Lib;

public class DataService : ISprint1Task6V5
{
    public string CheckSymmetricalWords(string value)
    {
        string res = null;
        string[] masStr = value.Replace(",","").Replace(".","").Split(' ');
        for (int i = 0; i < masStr.Length; i++) {
            bool symmetrical = true;
            for (int j = 1; j < masStr[i].Length; j++)
            {
                if (masStr[i].Substring(j, 1) != masStr[i].Substring(masStr[i].Length - j-1, 1)) symmetrical = false;
            }     
            if (symmetrical) res += masStr[i]+", ";
        }
        if (!string.IsNullOrEmpty(res)) return res.Substring(0, res.Length - 2);
        return "";
    }
} 
