namespace ReferenceTypes;

class Program
{
    static void Main(string[] args)
    {
        ValueTypes();
        
        ReferenceTypesArrays();

        ReferenceTypesClass();
    }

    private static void ReferenceTypesClass()
    {
        Person person1 = new Person();
        Person person2 = new Person();

        person1.FirstName = "Abdulahkim";
        person2 = person1;
        person1.FirstName = "Ömer";

        Console.WriteLine(person2.FirstName);

        Customer customer = new Customer();
        customer.FirstName = "Furkan";
        
        Employee employee = new Employee();
        employee.FirstName = "Engin";

        // customer = employee;     // error

        Person person3 = customer;
        customer.CreditCardNumber = "1243546";
        // person3.CreditCardNumber;    // error
        ((Customer)person3).CreditCardNumber = "2134567";
        
        Console.WriteLine(person3.FirstName);           // Furkan
        Console.WriteLine(customer.CreditCardNumber);   // 2134567


        PersonManager personManager = new PersonManager();
        personManager.Add(employee);
        personManager.Add(customer);
        personManager.Add(person1);
    }

    private static void ReferenceTypesArrays()
    {
        // reference types -> arrays, class, interface
        int[] numbers1 = new int[] { 1, 2, 3};
        int[] numbers2 = new int[] { 10, 20, 30};

        numbers1 = numbers2;
        numbers2[0] = 100;

        Console.WriteLine("numbers1[0]: " + numbers1[0]);   // 100
    }

    private static void ValueTypes()
    {
        // value types -> int, decimal, float, enum, boolean
        int number1 = 10;
        int number2 = 20;

        number1 = number2;
        number2 = 30;

        Console.WriteLine("number1: " + number1);   // 20
    }
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public string EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}