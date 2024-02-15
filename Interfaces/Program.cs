namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        // interface'ler new'lenemez
        // IPersonManager personManager = new IPersonManager();    // error

        IPersonManager customerManager = new CustomerManager();
        customerManager.Add();
        
        IPersonManager employeeManager = new EmployeeManager();
        employeeManager.Add();


        ProjectManager projectManager = new ProjectManager();
        projectManager.Add(customerManager);
        projectManager.Add(employeeManager);
        
        projectManager.Add(new InternManager());
    }
}

interface IPersonManager
{
    // unimplemented operation
    void Add();
    void Update();
}

// implements
class CustomerManager : IPersonManager
{
    // implemented operation
    public void Add()
    {
        // customer ekleme kodları
        Console.WriteLine("customer added");
    }

    public void Update()
    {
        Console.WriteLine("customer updated");
    }
}

class EmployeeManager : IPersonManager
{
    // implemented operation
    public void Add()
    {
        // employee ekleme kodları
        Console.WriteLine("employee added");
    }

    public void Update()
    {
        Console.WriteLine("employee updated");
    }
}

class InternManager : IPersonManager
{
    // implemented operation
    public void Add()
    {
        // intern ekleme kodları
        Console.WriteLine("intern added");
    }

    public void Update()
    {
        Console.WriteLine("intern updated");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}