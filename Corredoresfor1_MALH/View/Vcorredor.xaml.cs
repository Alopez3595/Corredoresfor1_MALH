using Corredoresfor1_MALH.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Corredoresfor1_MALH.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vcorredor : ContentPage
    {
        public Vcorredor()
        {
            InitializeComponent();
            BindingContext = new VMcorredor(Navigation);
        }
    }
}