using System;
using System.Collections.Generic;
using System.Text;

namespace StreamProgress
{
    public class StreamProgressInfo
    {
        private IProgressable file;

        public StreamProgressInfo(IProgressable file)
        {
            this.file = file;
        }

        public decimal CalculateCurrentPercent()
        {
            decimal result = file.BytesSent * 100 / file.Length;
            file.BytesSent += file.BytesSent;

            return result;
        }
    }
}
