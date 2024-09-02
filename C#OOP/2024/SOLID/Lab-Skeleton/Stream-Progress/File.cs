namespace StreamProgress
{
    public class File : IProgressable
    {
        private string name;

        public File(string name, decimal length, decimal bytesSent)
        {
            this.name = name;
            Length = length;
            BytesSent = bytesSent;
        }

        public decimal Length { get ; set ; }
        public decimal BytesSent { get ; set; }
    }
}
