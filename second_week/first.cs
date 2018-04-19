using System;
public class Program
{
    static public void Main (string[] args)
    {
    	Console.Write("文字列を入力してください>>");
        string str = Console.ReadLine();
        Console.WriteLine("あなたの入力した文字列はこれですね");
        Console.WriteLine("↓");
        Console.WriteLine(str);
    }
}
