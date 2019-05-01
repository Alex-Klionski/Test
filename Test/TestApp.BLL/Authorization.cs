using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL;

namespace TestApp.BLL
{
    public class Authorization : AuthorizationBase
    {
        public string Name { get; set; }
            
        public Authorization() : base(out rightLogin, out rightPassword)
        {

        }
        public bool Login(string Login, string Password)
        {
            AuthorizationBase authorizationbase = new AuthorizationBase(out rightLogin, out rightPassword);
            for (int i = 0; i < authorizationbase.Count; i++)
            {
                if (Login.ToString() == rightLogin[i] && Password.ToString() == rightPassword[i])
                {
                    Id = rightID[i];
                    ExamSolution.Answer = answer[i];
                    return true;
                }
                else
                    continue;
            }
            return false;
        }
    }
}
