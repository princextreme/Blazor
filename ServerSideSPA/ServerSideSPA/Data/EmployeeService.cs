using ServerSideSPA.Interface;
using ServerSideSPA.Models;

namespace ServerSideSPA.Data
{
    public class EmployeeService
    {
        private readonly IEmployee objemployee;

        public EmployeeService(IEmployee _objemployee)
        {
            objemployee = _objemployee;
        }

        public Task<List<Employee>> GetEmployeeList()
        {
            return Task.FromResult(objemployee.GetAllEmployees());
        }
        public Task<List<DailyWork>> GetWorks()
        {
            return Task.FromResult(objemployee.GetAllWorks());
        }

        public void Create(Employee employee)
        {
            objemployee.AddEmployee(employee);
        }
        public void CreateWork(DailyWork dailyWork )
        {
            objemployee.AddDailyWork(dailyWork);
        }
        public void CreateSubCategory(SubCategory subCategory)
        {
            objemployee.AddSubCategory(subCategory);
        }
        public Task<Employee> Details(int id)
        {
            return Task.FromResult(objemployee.GetEmployeeData(id));
        }

        public void Edit(Employee employee)
        {
            objemployee.UpdateEmployee(employee);
        }

        public void Delete(int id)
        {
            objemployee.DeleteEmployee(id);
        }
        public Task<List<City>> GetCities()
        {
            return Task.FromResult(objemployee.GetCityData());
        }
    }
}
