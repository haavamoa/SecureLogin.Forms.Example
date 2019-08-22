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
    public partial class ThirdPage : SafePageBase
    {
        public ThirdPage()
        {
            InitializeComponent();
        }
    }
}