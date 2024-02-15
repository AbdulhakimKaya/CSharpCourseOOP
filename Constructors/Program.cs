namespace Constructors;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer {Id = 1, FirstName = "Abdulhakim", LastName = "Kaya", City = "Diyarbakır"};

        Customer customer2 = new Customer();
        customer2.Id = 2;
        customer2.FirstName = "Ömer Faruk";
        customer2.LastName = "Doğan";
        customer2.City = "Malatya";
        
        Customer customer3 = new Customer(3, "Engin", "Demiroğ", "Ankara");

        Console.WriteLine(customer.FirstName);
        Console.WriteLine(customer2.FirstName);
        Console.WriteLine(customer3.FirstName);
    }
}

class Customer
{
    // default constructor
    public Customer()
    {
        Console.WriteLine("constructor worked");
    }

    public Customer(int ıd, string firstName, string lastName, string city)
    {
        Id = ıd;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}