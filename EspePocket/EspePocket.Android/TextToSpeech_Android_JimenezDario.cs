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

	var context ;
	#use global variable for reduce your its instantiations
	var languageIsos  = "es_MX";
	var locale;
	var testDisctionary;

        public TextToSpeech_Android()
        {
            context = Forms.Context;
            speaker = new TextToSpeech(context, this);

        }
        public void Speak(string text)
        {
            context = Forms.Context;
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(context, this);
                locale = new Java.Util.Locale(languageIso);// languageIso is locale string
                speaker.SetLanguage(locale);
            }
            else
            {
		#an appropriate name to the variable
                testDisctionary = new Dictionary<string, string>();
#pragma warning disable CS0618 // 'TextToSpeech.Speak(string, QueueMode, IDictionary<string, string>)' está obsoleto: 'deprecated'
                speaker.Speak(toSpeak, QueueMode.Flush, p);
#pragma warning restore CS0618 // 'TextToSpeech.Speak(string, QueueMode, IDictionary<string, string>)' está obsoleto: 'deprecated'
            }
        }

        #region IOnInitListener implementation
        public void OnInit(OperationResult status)
        {
            var locale = new Java.Util.Locale(languageIsos);
            speaker.SetLanguage(locale);
            if (status.Equals(OperationResult.Success))
            {
                testDisctionary = new Dictionary<string, string>();
#pragma warning disable CS0618 // 'TextToSpeech.Speak(string, QueueMode, IDictionary<string, string>)' está obsoleto: 'deprecated'
                speaker.Speak(toSpeak, QueueMode.Flush, p);
#pragma warning restore CS0618 // 'TextToSpeech.Speak(string, QueueMode, IDictionary<string, string>)' está obsoleto: 'deprecated'
            }

        }
        #endregion
    }
}

