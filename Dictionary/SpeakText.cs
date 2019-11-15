using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public class SpeakText
    {
        public static string EnglishLink = "https://responsivevoice.org/";
        public WebBrowser wb
        {
            get; set;
        }
        public SpeakText(WebBrowser wB)
        {
            this.wb = wB;
        }
        private void SetText(string data)
        {
            HtmlElement element = wb.Document.GetElementById("text");
            element.SetAttribute("value", data);
        }
        private void Speech()
        {
            HtmlElement element = wb.Document.GetElementById("playbutton");
            element.InvokeMember("click");
        }
        public void Speak(string data)
        {
            SetText("");
            SetText(data);
            Speech();
        }
    }
}
