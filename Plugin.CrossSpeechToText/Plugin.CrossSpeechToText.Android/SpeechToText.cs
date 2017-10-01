using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.CrossSpeechToText.Abstractions;
using Plugin.CrossSpeechToText.Droid;
using Xamarin.Forms;
using System.Threading;
using Android.Speech;


namespace Plugin.CrossSpeechToText.Droid
{
    public class SpeechToText : ISpeechToText
    {
        public static AutoResetEvent autoEvent = new AutoResetEvent(false);
        public static string SpeechText;
        public const int REQ_CODE_SPEECH_INPUT = 100;
        public async Task<string> StartVoiceInput(string title)
        {
            try
            {
                var voiceIntent = new Intent(RecognizerIntent.ActionRecognizeSpeech);
                voiceIntent.PutExtra(RecognizerIntent.ExtraLanguageModel, RecognizerIntent.LanguageModelFreeForm);
                voiceIntent.PutExtra(RecognizerIntent.ExtraPrompt, title);
                voiceIntent.PutExtra(RecognizerIntent.ExtraSpeechInputCompleteSilenceLengthMillis, 1500);
                voiceIntent.PutExtra(RecognizerIntent.ExtraSpeechInputPossiblyCompleteSilenceLengthMillis, 1500);
                voiceIntent.PutExtra(RecognizerIntent.ExtraSpeechInputMinimumLengthMillis, 15000);
                voiceIntent.PutExtra(RecognizerIntent.ExtraMaxResults, 1);
                voiceIntent.PutExtra(RecognizerIntent.ExtraLanguage, Java.Util.Locale.Default);

                SpeechText = "";
                autoEvent.Reset();
                ((Activity)Forms.Context).StartActivityForResult(voiceIntent, 100);
                
                await Task.Run(() => { autoEvent.WaitOne(new TimeSpan(0, 2, 0)); });
                
                return SpeechText;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        public static  void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            switch (requestCode)
            {
                case REQ_CODE_SPEECH_INPUT:
                    {
                        if (resultCode == Result.Ok)
                        {
                            var matches = data.GetStringArrayListExtra(RecognizerIntent.ExtraResults);
                            if (matches.Count != 0)
                            {
                                var textInput = matches[0];
                                if (textInput.Length > 500)
                                    textInput = textInput.Substring(0, 500);
                                SpeechToText.SpeechText = textInput;
                            }
                        }
                        SpeechToText.autoEvent.Set();
                        break;
                    }

            }
        }


    }
}