using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    // Index Example
    public class IP
    {
        private int[] segments = new int[4];

        public int this[int index]
        {
            get { return segments[index]; }
            set { segments[index] = value;}
        }
        public IP(int segment1 , int segment2, int segment3, int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;
        }
        public IP(string ip)
        {
            var result = ip.Split('.').Select(e=>int.Parse(e));
            segments = result.ToArray();
        }

        public string GetIP =>string.Join(".", segments);
    }
}
