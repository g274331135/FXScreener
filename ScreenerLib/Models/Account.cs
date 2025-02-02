namespace ScreenerLib.Models
{
    public class Account
    {
        /*
        private const int _User = 1737931;
        private const string _Password = "pi4twul";
        private const string _Host = "188.165.206.46";
        private const int _Port = 444;
         */
        public string Name { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public string Host { get; set; }

        public int Port { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
