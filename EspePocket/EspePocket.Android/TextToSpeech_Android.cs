using Android.Speech.Tts;
using Xamarin.Forms;
using System.Collections.Generic;
using Java.Lang;
using EspePocket.Droid;
using EspePocket.Models;

[assembly: Dependency(typeof(TextToSpeech_Android))]
namespace EspePocket.Droid
{
    public class TextToSpeech_Android : Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;
        public TextToSpeech_Android()
        {
            var c = Forms.Context;
            speaker = new TextToSpeech(c, this);

        }
        public void Speak(string text)
        {
            var c = Forms.Context;
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(c, this);
                var languageIso = "es_MX";
                var locale = new Java.Util.Locale(languageIso);// languageIso is locale string
                speaker.SetLanguage(locale);
            }
            else
            {
                var p = new Dictionary<string, string>();
#pragma warning disable CS0618 // 'TextToSpeech.Speak(string, QueueMode, IDictionary<string, string>)' está obsoleto: 'deprecated'
                speaker.Speak(toSpeak, QueueMode.Flush, p);
#pragma warning restore CS0618 // 'TextToSpeech.Speak(string, QueueMode, IDictionary<string, string>)' está obsoleto: 'deprecated'
            }
        }

        #region IOnInitListener implementation
        public void OnInit(OperationResult status)
        {
            var languageIsos = "es_MX";
            var locales = new Java.Util.Locale(languageIsos);
            speaker.SetLanguage(locales);
            if (status.Equals(OperationResult.Success))
            {
                var p = new Dictionary<string, string>();
#pragma warning disable CS0618 // 'TextToSpeech.Speak(string, QueueMode, IDictionary<string, string>)' está obsoleto: 'deprecated'
                speaker.Speak(toSpeak, QueueMode.Flush, p);
#pragma warning restore CS0618 // 'TextToSpeech.Speak(string, QueueMode, IDictionary<string, string>)' está obsoleto: 'deprecated'
            }

        }
        #endregion
    }
}