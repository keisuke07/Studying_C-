using System;

public class Program{
	static void Main(){
		int sum;

		Console.WriteLine("1つ目の整数を入力してください：");
		var i = int.Parse(Console.ReadLine());

		Console.WriteLine("2つ目の整数を入力してください：");
		var j = int.Parse(Console.ReadLine());

		sum = i + j;

		Console.WriteLine(i + "+" + j + "=" + sum);
	}
}