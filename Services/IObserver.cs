namespace WeatherForecast.Services
{
    public interface IObserver
    {
        void update(string src,decimal temp, decimal humidity, string weather, string weartherDescription, string icon = null);
    }
}
