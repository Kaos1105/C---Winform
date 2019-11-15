using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        DictionaryManager dictionary;
        //SpeakText speakTextVn;
        SpeakText speakText;
        bool isLoading1=true;
        //bool isLoading2=true;
        //WebBrowser wbVn = new WebBrowser();
        //WebBrowser wbEn = new WebBrowser();
        public Form1()
        {
            InitializeComponent();
            ChangeLoading();
            //wbVn.Visible = false;
            //wbVn.ScriptErrorsSuppressed = true;
            //wbVn.Navigate(SpeakText.VietNamLink);
            //wbVn.DocumentCompleted += WbVn_DocumentCompleted;
            //this.Controls.Add(wbVn);
            webBrowser1.Visible = false;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(SpeakText.EnglishLink);
            webBrowser1.DocumentCompleted += WbEn_DocumentCompleted;
            dictionary = new DictionaryManager();
            cbWord.DisplayMember = "Key";
            dictionary.LoadDataToComboBox(cbWord);
        }

        private void WbEn_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //throw new NotImplementedException();
            speakText = new SpeakText(webBrowser1);
            isLoading1 = false;
            ChangeLoading();
        }

        //private void WbVn_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //    speakTextVn = new SpeakText(wbVn);
        //    isLoading2 = false;
        //    ChangeLoading();
        //}
        void ChangeLoading()
        {
            this.Enabled = !(isLoading1);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK != MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                e.Cancel = true;
                return;
            }

        }

        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.DataSource == null)
                return;
            DictionaryData data = (DictionaryData)cb.SelectedItem;
            txtBoxMeaning.Text = data.Meaning;
            txtBoxExplain.Text = data.Explaination;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HtmlElement element = webBrowser1.Document.GetElementById("voiceselection");
            element.SetAttribute("value", "UK English Female");
            speakText.Speak((cbWord.SelectedItem as DictionaryData).Key);
        }

        private void btnSpeakEnglish1_Click(object sender, EventArgs e)
        {
            HtmlElement element = webBrowser1.Document.GetElementById("voiceselection");
            element.SetAttribute("value", "Vietnamese Female");
            speakText.Speak((cbWord.SelectedItem as DictionaryData).Meaning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtmlElement element = webBrowser1.Document.GetElementById("voiceselection");
            element.SetAttribute("value", "Vietnamese Female");
            speakText.Speak((cbWord.SelectedItem as DictionaryData).Explaination);
        }
    }
}
