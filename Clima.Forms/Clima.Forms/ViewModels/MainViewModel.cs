namespace Clima.Forms.ViewModels
{
    public class MainViewModel
    {
        public HomeViewModel Home { get; set; }

        public MainViewModel()
        {
            this.Home = new HomeViewModel();
        }
    }
}
