using POS1.Model;
using POS1.View;
using System.Threading.Tasks;

namespace POS1.Presenter
{
    class MyPresenter
    {
        private readonly IView mView;
        private IModel mModel;


        public MyPresenter(IView mView)
        {
            this.mView = mView;
            mModel = new MyModel();
        }

        public void doLogin() {
            mView.onLoginResult(mModel.validateLogin());
        }

        public void validateInput(string username, string password) {
            mModel.USERNAME = username;
            mModel.PASSWORD = password;
            mView.onValidateInput(mModel.validateInputs());
        }
    }
}
