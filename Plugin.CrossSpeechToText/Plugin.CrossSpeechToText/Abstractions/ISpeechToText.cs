using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.CrossSpeechToText.Abstractions
{
    public interface ISpeechToText
    {
        Task<string> StartVoiceInput(string title);
    }
}
