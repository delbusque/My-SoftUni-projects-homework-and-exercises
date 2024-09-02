using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamProgress
{
    public interface IProgressable
    {
        decimal Length { get; set; }
        decimal BytesSent { get; set; }
    }
}
