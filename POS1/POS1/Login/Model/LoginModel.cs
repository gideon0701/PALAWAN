using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS1.Presenter;

namespace POS1.Model
{
    class MyModel : IModel
    {
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
                    Employee emp = db.Employee.Where(e => e.USERNAME == mUsername && e.PASSWORD == mPassword).FirstOrDefault();

                    if (emp == null)
                    {
                        return -1;
                    }
                    else
                    {
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
