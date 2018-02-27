
namespace POS1.View
{
    public interface IView
    {
        void onLoginResult(int result);
        void onValidateInput(bool isNotEmpty);
    }
}
