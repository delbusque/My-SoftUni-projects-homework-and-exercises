using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressed
{
    public class Progress
    {
            IProgressable progressable;
            public Progress (IProgressable progressable)
            {
                    this.progressable = progressable;
            }

        public void currentProgress()
        {
            while (this.progressable.Sent < this.progressable.Length)
            {
                decimal result = this.progressable.Sent * 100 / this.progressable.Length;
                this.progressable.Sent += result;

                Console.WriteLine($"{result:F2}% are sent !!!");
                Thread.Sleep(1);
            }
        }
       
    }
}
