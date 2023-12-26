namespace WebApplication13.Services
{
    public class Books
    {
        public readonly string _name;
        public readonly double _price;

        public Books(string name, double price)
        {
            _name = name;
            _price = price;
        }
    }
    public interface IDiscountRule
    {
        double CalculatePrice(List<Books> books);
    }

    public class CombinationDiscountRule : IDiscountRule
    {
        private double _discountRate;
        public CombinationDiscountRule(double discountRate)
        {
            _discountRate = discountRate;
        }
        public double CalculatePrice(List<Books> books)
        {
            double price = 0;
            while (books.Count >= 2)
            {
                Books firstBook = books[0];
                books.RemoveAt(0);
                Books secondBook = books.Find(b => b._name != firstBook._name);
                if (secondBook != null)
                {
                    price += (firstBook._price + secondBook._price) * _discountRate;
                    books.Remove(secondBook);
                }
                else
                {
                    price += firstBook._price;
                }
            }
            price += books.Sum(a => a._price);
            return price;
        }
    }
    public class Order
    {
        public List<Books> books = new List<Books>();
        private List<IDiscountRule> _discountRules = new List<IDiscountRule>();

        public void Add_books(Books book)
        {
            books.Add(book);
        }
        public void Add_rules(IDiscountRule rule)
        {
            _discountRules.Add(rule);
        }
        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var rule in _discountRules)
            {
                total = rule.CalculatePrice(books);
            }

            return total;
        }
    }




}
