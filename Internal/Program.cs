using ConsoleApp_HomeWork8.Domain;
namespace ConsoleApp_HomeWork8.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caffe caffe = new Caffe();
            caffe.AddEmployee(new Employees("Denis Boiko", "manager",4500));
            caffe.AddEmployee(new Employees("Artem Besed", "waiter", 2500));
            caffe.AddEmployee(new Employees("Vlad Kulach", "waiter", 2500));
            caffe.AddEmployee(new Employees("Ilya Shkuri", "waiter", 2500));
            caffe.AddEmployee(new Employees("Ira Lonwake", "waiter", 2500));
            caffe.AddEmployee(new Employees("Alexa Boiko", "cook", 3500));
            caffe.AddEmployee(new Employees("Denys Popov", "cook", 3500));
            caffe.AddEmployee(new Employees("Mykyta Burd", "cook", 3500));
            caffe.AddEmployee(new Employees("Ira Tarenko", "cook", 3500));

            caffe.ShowEmployees();
            caffe.CreateMenu();
            caffe.employees[5].ShowMenu(caffe.menu);

        }
    }
}