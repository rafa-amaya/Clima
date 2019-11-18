

using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;

namespace Clima.Forms.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public string title;
        public string Title
        {
            get { return this.title; }
            set { this.SetValue(ref this.title, value); }
        }


        public ICommand GetWatherCommand => new RelayCommand(GetWather);

        private void GetWather()
        {
            this.Title = "Buenos Aires";
        }
    }
}
