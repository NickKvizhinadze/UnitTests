using System.Data.Entity;

namespace TestNinja.Mocking
{
    public class EmployeeController
    {
        //private EmployeeContext _db;
        private IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repo = null)
        {
            _repo = repo?? new EmployeeRepository();
        }

        public ActionResult DeleteEmployee(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Employees");
        }

        private ActionResult RedirectToAction(string employees)
        {
            return new RedirectResult();
        }
    }

    public class ActionResult { }
 
    public class RedirectResult : ActionResult { }
    
    public class EmployeeContext
    {
        public DbSet<Employee> Employees { get; set; }

        public void SaveChanges()
        {
        }
    }

    public class Employee
    {
    }
}