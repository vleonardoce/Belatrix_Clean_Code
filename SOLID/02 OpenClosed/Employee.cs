namespace SOLID._02_OpenClosed
{
    public class Employee
    {
        public Employee(int id, string name, string type)
        {
            this.ID = id;
            this.Name = name;
            this.EmployeeType = type;
        }

        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public bool IsPermanent
        {
            get { return this.EmployeeType == "Permanent"; }
        }
        public decimal Bonus
        {
            get { return (this.IsPermanent ? .1M : .05M) * this.Salary; }
        }

    }
}