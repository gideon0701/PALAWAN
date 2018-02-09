using ScannerSampleLab1.Model;
using ScannerSampleLab1.View;

namespace ScannerSampleLab1.Presenter
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
