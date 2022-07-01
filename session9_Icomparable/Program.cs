using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

  class Employee :IComparable<Employee>
  {
    public string Name { get; set; }
    public int ID { get; set; }

    public override string ToString()
    {
      return $"{Name} {ID}";
    }

    public int CompareTo(Employee other)
    { 
    return this.Name.CompareTo(other.Name);
    }

// Sort By ID
    //   public int CompareTo(Employee other)
    // { 
    // if (this.ID > other.ID)
    // {
    //     return 1;
    // }
    // else if (this.ID < other.ID)
    // {
    //     return -1;
    // }
    // else
    // {
    //     return 0;
    // }
    // }

  }

    internal class Program
    {
        static void Main(string[] args)
        {
           List<Employee> lstEmployee = new List<Employee>{
            new Employee {Name = "akbar" , ID =1},
            new Employee {Name = "asghar" , ID =2},
            new Employee {Name = "mehdi" , ID =4},
            new Employee {Name = "batol" , ID =5},
            new Employee {Name = "kamran" , ID =6},
            new Employee {Name = "rashin" , ID =10},
            new Employee {Name = "ahmda" , ID =13},

           };
           lstEmployee.Sort();

          foreach (var item in lstEmployee)
          {
           System.Console.WriteLine(item.ToString()); 
          }
        }
    }
}
