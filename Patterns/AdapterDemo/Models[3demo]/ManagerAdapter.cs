namespace AdapterDemo.Models_3demo_
{
    class ManagerAdapter : IPerson
    {
        private Manager manager;

        public ManagerAdapter()
        {
            this.manager = new Manager();
        }
        public int CalculateSalary()
        {
            return manager.SalaryRate * manager.Hours;
        }
    }
}
