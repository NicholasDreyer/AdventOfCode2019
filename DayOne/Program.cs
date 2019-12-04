using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string masses = @"57351
149223
142410
129063
91757
52486
125555
124161
104558
110002
140284
131259
142148
69648
73179
89820
125606
70238
131217
99388
71989
126743
55136
128148
52974
131314
82350
126565
54418
105347
71981
146156
113626
117829
55419
91350
137748
113160
102462
100948
101731
131526
139132
51796
100849
122579
132301
51675
86607
140890
77532
81217
149549
113161
119361
109709
64495
103062
72313
140119
77352
91658
141341
91664
64771
88263
102357
149925
123608
88368
57809
65165
63937
78600
134725
58438
62763
131789
119646
65649
143975
142866
97922
64427
149451
84896
75863
53950
55625
146904
50460
99284
125904
85856
60281
79113
111661
145106
105568
147400";

            string[] mass = masses.Split(new[] { "\r\n" }, StringSplitOptions.None); // Array of strings containing all masses given

            int totalFuel = 0; // Total fuel required for all masses

            foreach (string s in mass) // Iterate through each string in the split string array containing all masses
            {
                if (Int32.TryParse(s, out int singleMass)) // Attempt to parse each string in the array to an int
                {
                    totalFuel += (singleMass / 3) - 2; // Formula to see how much fuel is required for given mass added to totalFuel (Using int truncation to our advantage)
                }
            }

            Console.WriteLine(totalFuel); // Print in terminal total fuel required
        }
    }
}
