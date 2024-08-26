using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressed
{
    internal class Music : IProgressable
    {
        public decimal Sent { get ; set ; }
        public decimal Length { get ; set ; }

        public string Author { get; set; }
        public string Song { get; set; }
    }
}
