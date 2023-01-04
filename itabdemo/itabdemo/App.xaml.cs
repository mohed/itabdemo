using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using itabdemo.Services;
using itabdemo.Views;

namespace itabdemo
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<ItabService>();
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

