using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopUpTester.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpView : PopupPage
    {
        public PopUpView(MyViewModel myViewModel)
        {
            InitializeComponent();
            BindingContext = myViewModel;
        }
    }
}