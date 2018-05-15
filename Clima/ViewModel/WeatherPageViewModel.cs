

namespace Clima.ModelView
{
	using System;

    using Xamarin.Forms;
    public class WeatherPageViewModel : ContentPage
    {
        public WeatherPageViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

