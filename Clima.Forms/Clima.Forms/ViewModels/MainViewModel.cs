namespace Clima.Forms.ViewModels
{
    public class MainViewModel
    {
        private static MainViewModel instance;
        public HomeViewModel Home { get; set; }
        public DetalleViewModel Detalle { get; set; }

        public MainViewModel()
        {
            instance = this;
        }
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
    }
}
