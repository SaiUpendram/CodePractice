
using System;
  

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | 
                        AttributeTargets.Method, AllowMultiple = true)]

    class InformationAttribute : Attribute
    {
        public string InformationString{ get; set; }
    }
  

[Information(InformationString = "Class")] public class Employee
{
  
    private int empID;
    private string name;
  
    [Information(InformationString = "Constructor")] public Employee(int empID, string name)
    {
        this.empID = empID;
        this.name = name;
    }
  
    [Information(InformationString = "Method")] public void display()
    {
        Console.WriteLine("Emp ID: {0}", empID);
        Console.WriteLine("Name: {0}", name);
    }
}
  

public class GFG {
  

    public static void Main(string[] args)
    {
        Employee e = new Employee(1001, "Sai Upendram");
        e.display();
    }
}
