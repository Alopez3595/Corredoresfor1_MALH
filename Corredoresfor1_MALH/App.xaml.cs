using Corredoresfor1_MALH.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Corredoresfor1_MALH
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vcorredor ();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
