using Plugin.CrossSpeechToText.Stt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossSpeechToTextSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var result = await CrossSpeechToText.StartVoiceInput("Voice Input!");
            txtResult.Text = result;
        }
    }
}
