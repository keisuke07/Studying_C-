using System;
public class Program
{
    static public void Main (string[] args)
    {
        Console.WriteLine("テストの点数を入力してください。");
        int num = int.Parse(Console.ReadLine());
        if (num <= 29){
        	Console.WriteLine("赤点です。");
        }else if (30 <= num && num <= 49){
        	Console.WriteLine("赤点ギリギリです。");
        }else if(50 <= num && num <= 74){
        	Console.WriteLine("もう少し頑張りましょう。");
        }else if(75 <= num && num <= 90){
        	Console.WriteLine("合格");
        }else{
        	Console.WriteLine("満点");
        }
    }
}
