using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecureLogin.Base
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentView
    {
        private SafePageBase m_safePageBase;

        public LoginView(SafePageBase safePageBase)
        {
            InitializeComponent();
            m_safePageBase = safePageBase;
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            m_safePageBase.OnLoggedIn();
        }
    }
}