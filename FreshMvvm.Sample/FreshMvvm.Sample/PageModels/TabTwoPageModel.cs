using System.Reflection;
using Xamarin.Forms;

namespace FreshMvvm.Sample.PageModels
{
    public class TabTwoPageModel : FreshBasePageModel
    {
        public string UnicornText
        {
            get
            {
                return "unicorn!";
            }
        }

        public Command ShowUnicornCommand
        {
            get
            {
                return new Command(() =>
                {
                    CoreMethods.PushPageModel<UnicornPageModel>("http://verslu.is/img/assets/logo-white.png", true);
                });
            }
        }
    }
}