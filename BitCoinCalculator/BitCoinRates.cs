using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCoinCalculator
{
    public class BitCoinRates
    {
        public bpi bpi { get; set; }
    }
    public class bpi
    {
        public EUR Eur { get; set; }
    }
    public class EUR
    {
        public string code { get; set; }
        public float rate_float { get; set; }
    }
}
