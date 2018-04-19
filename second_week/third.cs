using System;
public class Program
{
    static public void Main (string[] args)
    {
        Console.Write("数値を入力してください(1〜5まで)>>");
        int i = int.Parse(Console.ReadLine());
        switch (i){
        	case 1:
        		Console.WriteLine("あなたが入力したのは{0}ですね", i);
        		break;
        	case 2:
        		Console.WriteLine("あなたが入力したのは{0}ですね", i);
        		break;
        	case 3:
        		Console.WriteLine("あなたが入力したのは{0}ですね", i);
        		break;
        	case 4:
        		Console.WriteLine("あなたが入力したのは{0}ですね", i);
        		break;
        	case 5:
        		Console.WriteLine("あなたが入力したのは{0}ですね", i);
        		break;
        	default:
        		Console.WriteLine("1〜5を入力してください。");
        		break;
        }
    }
}
