using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecureLogin.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecureLogin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : SafePageBase
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private async void Next_OnClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new ThirdPage());
        }
    }
}