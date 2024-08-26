using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressed
{
    public interface IProgressable
    {
        decimal Sent{ get; set; }
        decimal Length { get; set; }
    }
}
