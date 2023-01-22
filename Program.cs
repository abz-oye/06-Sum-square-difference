using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
			long sum = 1;
			long x = 0;
			long square = 0;
			long diff = 0;

			for (int i = 2; i <= n; i++) {
				sum = sum + (i*i);
			}

			for (int i = 1; i <= n; i++) {
				x = x + i;
			}

			square = x*x;

			diff = square - sum;
			Console.WriteLine(diff);
        }
    }
}
