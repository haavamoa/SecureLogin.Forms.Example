using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SecureLogin.Base
{
    public class SafePageBase : ContentPage
    {
        private View m_AfterLoggedInContent;

        public SafePageBase()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }

        public void OnSleep()
        {
            if (!(Content is LoginView))
            {
                m_AfterLoggedInContent = Content;
            }

            Content = new LoginView(this);
        }

        public void OnLoggedIn()
        {
            Content = m_AfterLoggedInContent;
        }
    }
}