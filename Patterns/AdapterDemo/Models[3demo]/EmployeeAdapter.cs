namespace AdapterDemo.Models_3demo_
{
    class EmployeeAdapter : IPerson
    {
        private Employee employee;

        public EmployeeAdapter()
        {
            this.employee = new Employee();
        }

        public int CalculateSalary()
        {
            return employee.SalaryRate * employee.Hours;
        }
    }
}
