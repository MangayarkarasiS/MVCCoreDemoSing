namespace Demo1Core.Models
{
    public class MockEmp : IEmp
    {
        private List<Emp> Emps;

        public MockEmp() {
        Emps= new List<Emp>()
        {
             new Emp(){EmpId = 1,EmpName="Gautham",EmpDesignation="IT Manager",EmpSalary=100000},
             new Emp(){EmpId = 2,EmpName="Krish",EmpDesignation="Tech Lead",EmpSalary=50000},
             new Emp(){EmpId = 3,EmpName="Ram",EmpDesignation="Developer",EmpSalary=40000}
        };
        }

        public Emp GetEmp(int id)
        {
           return Emps.FirstOrDefault(e => e.EmpId == id);
        }

        
    }
}
