
namespace POS1.View
{
    public interface IView
    {
        void onLoginResult(bool result);
        void onValidateInput(bool isNotEmpty);
    }
}
