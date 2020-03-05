
using MvvmHelpers;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PopUpTester
{
    public class MyViewModel : BaseViewModel
    {
        public ICommand AcaoCommand => new Command(async () => { await Acao(); });
        public ICommand AcaoPopUpCommand => new Command(async () => { await AcaoPopUp(); });

        private string _texto = "here we go!";
        public string Texto
        {
            get => _texto;
            set => SetProperty(ref _texto, value);
        }

        public async Task Acao()
        {
            await PopupNavigation.Instance.PushAsync(new PopUp.PopUpView(this));
            await App.Current.MainPage.DisplayAlert("", "Deu bom!!", "Ok");
            Texto = "All fine";
        }

        public async Task AcaoPopUp()
        {
            Texto = "PopUp Actions!!!!!! xD";
            await PopupNavigation.Instance.PopAsync();
        }

    }    
}
