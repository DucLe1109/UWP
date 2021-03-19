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
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using News_Application.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace News_Application
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<Article> Articles;
        public MainPage()
        {
            this.InitializeComponent();
            Articles = new ObservableCollection<Article>();
            
        }
        public async void callApi(string q, string from, string sortBy, string apiKey)
        {
            if (q != "" && from != "" && sortBy != "" && apiKey != "")
            {
                
                var url = string.Format("http://newsapi.org/v2/everything?q={0}&from={1}&sortBy={2}&apiKey={3}", q, from, sortBy, apiKey);
                var news = await News.GetNews(url) as Root;
                news.articles.ForEach(n =>
                {
                    Articles.Add(n);
                });
            }
            else
            {
                note.Text = "Please put information down input form !";
            }

        }

        private void MewsItemGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            Article ar = e.ClickedItem as Article;
            Frame.Navigate(typeof(ArticleView), ar);
        }
        private void search_button_Click(object sender, RoutedEventArgs e)
        {
            if (Articles.Count != 0)
            {
                this.note.Text = "";
            }
            string q, from, sortBy, apikey;
            q = q_.Text;
            from = from_.Text;
            sortBy = sortBy_.Text;
            apikey = apikey_.Text;
            callApi(q, from, sortBy, apikey);
            

        }


        private void home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), new object());
        }

        private void book_mark_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BookMark_view), new object());
        }
        private void Dwindle_Toogle_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

       
    }
}
