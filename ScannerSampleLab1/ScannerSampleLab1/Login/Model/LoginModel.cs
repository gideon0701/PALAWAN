using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScannerSampleLab1.Presenter;

//HELLO FROM THE OTHER SIDE
namespace ScannerSampleLab1.Model
{
    class MyModel : IModel
    {
        private string mUsername;
        private string mPassword;
        private TestEntities db;
        public MyModel()
        {
            db = new TestEntities();
        }

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

        public bool validateLogin()
        {
            Employee emp = db.Employee.Where(e => e.USERNAME == mUsername && e.PASSWORD == mPassword).FirstOrDefault();
            
            if (emp == null)
            {
                return false;
            }
            else {
                return true;
            }
        }

        public bool validateInputs()
        {
            return mUsername != "" && mPassword != "";
        }
    }
}
