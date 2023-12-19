using MessagePack;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;

namespace Demo1Core.Models
{
    public class Emp
    {
       
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public int EmpSalary { get; set; }
              
    }
}
/*Database - system will be automatically creating a name for DB
 *Table  -  Emp
 columns - EmpId (int), EmpNAme(varchar(MAx),*/