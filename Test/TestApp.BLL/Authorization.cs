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
        AuthorizationBase authorizationbase = new AuthorizationBase(out rightLogin, out rightPassword);
        public Authorization() : base(out rightLogin, out rightPassword)
        {

        }
        public bool Login(string Login, string Password)
        {
            for(int i = 0; i < authorizationbase.Count; i++)
            {
                if (Login.ToString() == rightLogin[i] && Password.ToString() == rightPassword[i])
                {
                    return true;
                }
                else
                    continue;
            }
            return false;
        }
    }
}
