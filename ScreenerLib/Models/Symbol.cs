namespace ScreenerLib.Models
{
    public class Symbol
    {
        public string Name { get; set; }
        public string Market { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
