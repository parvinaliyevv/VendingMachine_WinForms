namespace homework
{
    public class Snack
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public double Price { get; set; }

        public Snack(string name, string url, double price)
        {
            Name = name;
            Url = url;
            Price = price;
        }
        public Snack(string name, string price)
        {
            Name = name;
            Price = double.Parse(price);
        }
        public Snack() { }

        public override string ToString() => string.Format("{0} {1} AZN", Name, Price);

        public override bool Equals(object? obj)
        {
            return ToString() == obj.ToString();
        }
    }
}
