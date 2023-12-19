namespace WebApplication13.Models
{
    public class Employee
    {
       public string name { get; set; }
       public int years {  get; set; }
       public string sex { get; set; }
       public int salarytype { get; set; }
       public int salary { get; set; }
    }
    //OCP
    public interface ISalary
    {
        int Calculates(Employee employee);
    }
    public class FullTimeSalary : ISalary
    {
        public int Calculates(Employee employee)
        {
            return employee.salary;
        }
    }
    public class PartTimeSalary : ISalary
    {
        private int hour {  get; set; }
        public PartTimeSalary(int _hour)
        {
            hour = _hour;
        }
        public int Calculates(Employee employee)
        {
            return employee.salary * hour;
        }

    }
    //介面隔離原則
    public interface IWork
    {
        void EatLunch();
    }
    public interface IWorkProgrammer : IWork
    {
        void Coding();
        void Debug();
    }
    public class Programmer: Employee, IWorkProgrammer
    {
        public void Coding()
        {
            Console.WriteLine("碼農!");
        }
        public void Debug()
        {
            Console.WriteLine("除蟲!");
        }
        public void EatLunch()
        {
            Console.WriteLine("吃飯!");
        }
    }
    public class Programmanager : Employee, IWork
    {
        public void EatLunch()
        {
            Console.WriteLine("等吃飯!");
        }
    }
    public class CalculateSalary
    {
        //依賴反轉
        private ISalary salaryCalculator;
        public CalculateSalary(ISalary salaryCalculator)
        {
            this.salaryCalculator = salaryCalculator;
        }
        public int Calculate(Employee employee)
        {
            return salaryCalculator.Calculates(employee);
        }
    }

}
