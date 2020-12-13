using System.Globalization;

namespace Ex02_Listas
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void SalaryRaise(double raisePercent)
        {
            Salary = Salary * (1 + raisePercent/100);
        }

        public override string ToString()
        {
            return Id.ToString() + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
