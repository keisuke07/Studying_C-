using System;
public class Program
{
    static public void Main (string[] args)
    {
    	int i,j;
        Console.Write("計算を行う演算子を入力してください>>");
        string str = Console.ReadLine();
        switch (str){
        	case "+":
        		Console.WriteLine("それでは足し算の計算を始めます。");
        		Console.Write("1つ目の整数を入力してください>>");
        		i = int.Parse(Console.ReadLine());
        		Console.Write("2つ目の整数を入力してください>>");
        		j = int.Parse(Console.ReadLine());
        		Console.WriteLine("計算結果は{0}です", i + j);
        		break;
        	case "-":
        		Console.WriteLine("それでは引き算の計算を始めます。");
        		Console.Write("1つ目の整数を入力してください>>");
        		i = int.Parse(Console.ReadLine());
        		Console.Write("2つ目の整数を入力してください>>");
        		j = int.Parse(Console.ReadLine());
        		Console.WriteLine("計算結果は{0}です", i - j);
        		break;
        	case "*":
        		Console.WriteLine("それでは掛け算の計算を始めます。");
        		Console.Write("1つ目の整数を入力してください>>");
        		i = int.Parse(Console.ReadLine());
        		Console.Write("2つ目の整数を入力してください>>");
        		j = int.Parse(Console.ReadLine());
        		Console.WriteLine("計算結果は{0}です", i * j);
        		break;
        	case "/":
        		Console.WriteLine("それではわり算の計算を始めます。");
        		Console.Write("1つ目の整数を入力してください>>");
        		i = int.Parse(Console.ReadLine());
        		Console.Write("2つ目の整数を入力してください>>");
        		j = int.Parse(Console.ReadLine());
        		Console.WriteLine("計算結果は{0}です", i / j);
        		break;
        }
    }
}
