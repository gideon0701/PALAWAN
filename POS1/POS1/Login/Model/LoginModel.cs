using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS1.Presenter;
using System.Threading;

namespace POS1.Model
{
    class LoginModel : IModel
    {
        public static int empType;

        private string mUsername;
        private string mPassword;

        public string PASSWORD
        {
            get
            {
                return mPassword;
            }
            set {
                mPassword = value;
            }
        }

        public string USERNAME
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }

        public int validateLogin()
        {
            using (var db = new TestEntities())
            {
                try
                {
                    var employee = db.Employee
                        .AsNoTracking()
                        .Where(e => e.USERNAME == mUsername && e.PASSWORD == mPassword)
                        .Single();

                    if (employee == null)
                    {
                        return -1;
                    }
                    else
                    {
                        empType = employee.TYPE ?? 3;
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                    return -2;
                }
            }    
        }

        public bool validateInputs()
        {
            return mUsername != "" && mPassword != "";
        }
    }
}
