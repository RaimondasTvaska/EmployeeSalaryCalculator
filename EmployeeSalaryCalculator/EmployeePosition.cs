using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    public class EmployeePosition
    {
        public string PositionName { get; set; }
        public int BasicSalary { get; set; }
        public int Coeficient { get; set; }
        public EmployeePosition( string positionName, int basicsalary, int coeficient)
        {
            PositionName = positionName;
            BasicSalary = basicsalary;
            Coeficient = coeficient;
        }
    }
}
