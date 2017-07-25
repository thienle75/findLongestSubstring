using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string data = "abcwxyzabghwxyz";
			string value = LongestRepeatedSubstring(data);
			Console.WriteLine(value);
		}
        

        public static string LongestRepeatedSubstring(string str)
		{
			if (string.IsNullOrEmpty(str))
				return null;

			int N = str.Length;
			string[] substrings = new string[N];

			for (int i = 0; i < N; i++)
			{
				substrings[i] = str.Substring(i);
			}

			Array.Sort(substrings);

			string result = "";

			for (int i = 0; i < N - 1; i++)
			{
				string lcs = LongestCommonString(substrings[i], substrings[i + 1]);

				if (lcs.Length > result.Length)
				{
					result = lcs;
				}
			}

			return result;
		}

		private static string LongestCommonString(string a, string b)
		{
			int n = Math.Min(a.Length, b.Length);
			string result = "";

			for (int i = 0; i < n; i++)
			{
				if (a[i] == b[i])
					result = result + a[i];
				else
					break;
			}

			return result;
		}
	}
	
}
