using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		var n = Convert.ToInt32(Console.ReadLine());

		for (var i = 0; i <= n; i++)
		{
			var str = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(str)) throw new NullReferenceException("Invalid value");

			var result = 0;

			for (var j = 1; j < str.Length; j++)
			{
				var dictionary = new Dictionary<string, int>();
				for (var k = 0; k < str.Length - j + 1; k++)
				{
					var substr = str.Substring(k, j).ToCharArray();
					Array.Sort(substr);
					var substrSorted = string.Join("", substr);

					var keys = dictionary.Keys.ToList();
					if (keys.Contains(substrSorted)) dictionary[substrSorted] += 1;
					else dictionary.Add(substrSorted, 1);

					result += dictionary[substrSorted] - 1;
				}
			}
			Console.WriteLine(result);
		}
	}
}