using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment3
{
    public partial class AboutPage : ContentPage
    {
        public string WebSource { get; set; }

        public AboutPage()
        {
            InitializeComponent();
        }

        public AboutPage(string url)
        {
            WebSource = url;
            InitializeComponent();
            webView.Source = WebSource;
        }
    }
}
