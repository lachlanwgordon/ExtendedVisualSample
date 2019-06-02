using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace VisualExtension.Pages
{
    public partial class FormPage : ContentPage
    {
        public FormPage()
        {
            InitializeComponent();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(3000);
            Indicator.IsVisible = false;

        }
    }
}