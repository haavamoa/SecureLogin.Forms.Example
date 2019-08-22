using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecureLogin.Base;
using Xamarin.Forms;

namespace SecureLogin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : SafePageBase
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Next_OnClicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SecondPage());
        }
    }
}
