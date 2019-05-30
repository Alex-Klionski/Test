using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL;

namespace TestApp.BLL
{
    public class ExamSolution
    {
        public static string Answer { get; set; }
        ExamSolutionBase solution = new ExamSolutionBase();

        public void SolutionPass()
        {
            solution.SolutionRight();
        }

        public void SolutionNotPass()
        {
            solution.SolutionNotRight();
        }
    }
}
