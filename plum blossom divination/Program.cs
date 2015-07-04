using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plum_blossom_divination
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine('\u3041');
			plumBlossom tester = new plumBlossom(4, 23, 1999, 7, 8);
			tester.calculateHexagram();
        }
    }

    class plumBlossom
    {
        private int month;
        private int day;
        private int year;

        private int hour;
        private int minute;

		private char primaryTrigram;
		private char secondaryTrigram;

		private static char[] trigrams = { '\u2631', '\u2630', '\u2635', '\u2636', '\u2633', '\u2634', '\u2632', '\u2637' };

        public plumBlossom()
        {
			this.month = 1;
			this.day = 1;
			this.year = 1;
			this.hour = 1;
			this.minute = 1;
        }
		public plumBlossom(int month, int day, int year, int hour, int minute)
		{
			this.month = month;
			this.day = day;
			this.year = year;
			this.hour = hour;
			this.minute = minute;
			
		}

		public void calculateHexagram()
		{
			int dateSum;
			int timeSum;

			dateSum = this.month + this.day + this.year;
			timeSum = dateSum + this.hour + this.minute;

			primaryTrigram = trigrams[dateSum % 8];
			secondaryTrigram = trigrams[dateSum % 8];

			Console.WriteLine(primaryTrigram);
			Console.WriteLine(secondaryTrigram);
		}
    }
}
