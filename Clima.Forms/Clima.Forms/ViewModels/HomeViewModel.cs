using Clima.Forms.Models;
using Clima.Forms.Services;
using Clima.Forms.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Clima.Forms.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private ApiService apiService;
        public ClimaData climaData { get; set; }
        public ICommand GetWatherCommand => new RelayCommand(GetWather);
        public ICommand TitleCommand => new RelayCommand(Detalle);             
        public IList<CiudadData> Ciudades { get { return Datos.ObjContactList.ciudades; } }
        public CiudadData selectCiudades;
        public CiudadData SelectCiudades
        {
            get { return this.selectCiudades; }
            set { this.SetValue(ref this.selectCiudades, value); }
        }
        public string title;
        public string Title
        {
            get { return this.title; }
            set { this.SetValue(ref this.title, value); }
        }
        public string temperature;
        public string Temperature
        {
            get { return this.temperature; }
            set { this.SetValue(ref this.temperature, value); }
        }
        public string speed;
        public string Speed
        {
            get { return this.speed; }
            set { this.SetValue(ref this.speed, value); }
        }
        public string humidity;
        public string Humidity
        {
            get { return this.humidity; }
            set { this.SetValue(ref this.humidity, value); }
        }
        public string visibility;
        public string Visibility
        {
            get { return this.visibility; }
            set { this.SetValue(ref this.visibility, value); }
        }
        public HomeViewModel()
        {
            this.apiService = new ApiService();
        }
        private async void GetWather()
        {
            if (SelectCiudades == null)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debe seleccionar una ciudad de la lista",
                    "Accept");
                return;
            }

            var response = await this.apiService.GetAsync<ClimaData>(GenerateRequestUri(Constants.OpenWeatherMapEndpoint));
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }
            climaData = (ClimaData)response.Result;

            this.Title = climaData.Title;
            this.Temperature = climaData.Main.Temperature.ToString();
            this.Speed = climaData.Wind.Speed.ToString();
            this.Humidity = climaData.Main.Humidity.ToString();
            this.Visibility = climaData.Weather[0].Visibility;
        }
        private async void Detalle()
        {
            if (!string.IsNullOrEmpty(Title))
            {
                MainViewModel.GetInstance().Detalle = new DetalleViewModel(climaData);
                await Application.Current.MainPage.Navigation.PushAsync(new DetallePage());
            }
        }

        string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            requestUri += $"?q={SelectCiudades.Name}";
            requestUri += "&units=imperial"; // or units=metric
            requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
            return requestUri;
        }
    }
}
