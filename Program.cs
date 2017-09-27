using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterCount
{
    class Program
    {
        static void Main(string[] args)
        {
			var text = "Bacon ipsum dolor amet porchetta corned beef doner leberkas, shank strip steak frankfurter capicola t-bone short loin kielbasa biltong flank cow. Beef pastrami meatball turkey corned beef rump andouille. Andouille swine ball tip tenderloin, porchetta tail pancetta pork. Beef jowl pastrami picanha sirloin prosciutto.";
			var counts = countLetters(text.Replace(" ", ""));

			var letters = counts.OrderByDescending(c => c.Value).ToList();

			for (var i = 0; i < 5; i++)
			{
				Console.WriteLine($"Letter: {letters[i].Key}, Count: {letters[i].Value}");
			}
				
		}

		static Dictionary<char, int> countLetters(string text)
		{
			var counts = new Dictionary<char, int>();

			foreach(var letter in text)
			{
				if(counts.ContainsKey(letter))
				{
					counts[letter]++;
				}
				else 
				{
					counts[letter] = 1;
				}
			}

			return counts;
		}
    }
}
