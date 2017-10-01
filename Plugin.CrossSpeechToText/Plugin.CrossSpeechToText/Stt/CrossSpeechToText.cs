using Plugin.CrossSpeechToText.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Plugin.CrossSpeechToText.Stt
{
    public class CrossSpeechToText
    {
        public static async Task<string> StartVoiceInput(string title)
        {
            var result = await DependencyService.Get<ISpeechToText>().StartVoiceInput(title);
            return result;
        }
        
    }
}
