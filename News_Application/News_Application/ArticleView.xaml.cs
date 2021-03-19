using News_Application.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace News_Application
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ArticleView : Page
    {
        private Article current_article;
        public ArticleView()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var article = e.Parameter as Article; // e.parameter : nhận tham số.
            this.current_article = article;
            Image.Source = new BitmapImage(new Uri(article.urlToImage,UriKind.Absolute));
            Author.Text = article.author;
            Title.Text = article.title;
            Description.Text = article.description;
            base.OnNavigatedTo(e);
        }
        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), new object());
        }


        private void btnBookMark_Click_1(object sender, RoutedEventArgs e)
        {
            DataAccess.AddData(current_article.urlToImage,this.current_article.author,this.current_article.title,this.current_article.description);
        }
    }
}
