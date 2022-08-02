using ServerSideSPA.Models;

namespace ServerSideSPA.Interface
{
    public interface IEmployee
    {
        public List<Employee> GetAllEmployees();
        public List<DailyWork> GetAllWorks();
        public void AddEmployee(Employee employee);
        public void AddDailyWork(DailyWork dailyWork);
        public void UpdateEmployee(Employee employee);
        public Employee GetEmployeeData(int id);
        public void DeleteEmployee(int id);
        public List<City> GetCityData();
    }
}
