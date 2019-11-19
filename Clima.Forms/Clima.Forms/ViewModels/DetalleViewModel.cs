using System;
using System.Collections.Generic;
using System.Text;
using Clima.Forms.Models;

namespace Clima.Forms.ViewModels
{
    public class DetalleViewModel: BaseViewModel
    {
        public string title;
        public string Title
        {
            get { return this.title; }
            set { this.SetValue(ref this.title, value); }
        }

        public DetalleViewModel(ClimaData climaData)
        {
            Title = climaData.Title;
        }
    }
}
