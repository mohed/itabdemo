using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace itabdemo.ViewModels
{
    public class ItabViewModel : BaseViewModel
    {
        private string response = "";

        public string Response
        {
            get { return response; }
            set { SetProperty(ref response, value); }
        }

        public ItabViewModel()
        {
            Title = "Itab comunicator";
            NotifyItab = new Command(async () =>
            {
                Response = await Itab.notify();
            });
        }

        public ICommand NotifyItab { get; }
    }
}
