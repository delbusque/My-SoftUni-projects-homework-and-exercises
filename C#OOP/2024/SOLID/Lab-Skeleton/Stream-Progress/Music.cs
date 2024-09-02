using System;
using System.Collections.Generic;
using System.Text;

namespace StreamProgress
{
    public class Music : IProgressable
    {
        private string artist;
        private string album;

        public Music(string artist, string album, decimal length, decimal bytesSent)
        {
            this.artist = artist;
            this.album = album;
            Length = length;
            BytesSent = bytesSent;
        }

        public decimal Length { get; set; }

        public decimal BytesSent { get; set; }
    }
}
