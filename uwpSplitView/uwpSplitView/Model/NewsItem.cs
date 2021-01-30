using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace uwpSplitView.Model
{
    public class NewsItem
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string Dateline { get; set; }
        public string Image { get; set; }
        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();
            items.Add(new NewsItem()
            {
                ID = 1,
                Category = "Financial",
                Headline = "Euro",
                Subhead = "News",
                Dateline = "29-01-2021",
                Image = "Assets/Financial.png"
            });
            items.Add(new NewsItem()
            {
                ID = 2,
                Category = "Financial",
                Headline = "Gold",
                Subhead = "News",
                Dateline = "29-01-2021",
                Image = "Assets/Financial2.png"
            });
            items.Add(new NewsItem()
            {
                ID = 3,
                Category = "Financial",
                Headline = "Dollar",
                Subhead = "News",
                Dateline = "29-01-2021",
                Image = "Assets/Financial3.png"
            });
            items.Add(new NewsItem()
            {
                ID = 4,
                Category = "Financial",
                Headline = "Gold",
                Subhead = "News",
                Dateline = "29-01-2021",
                Image = "Assets/Financial4.png"
            });
            items.Add(new NewsItem()
            {
                ID = 5,
                Category = "Financial",
                Headline = "Diamond",
                Subhead = "News",
                Dateline = "29-01-2021",
                Image = "Assets/Financial5.png"
            });




            items.Add(new NewsItem()
            {
                ID = 6,
                Category = "Food",
                Headline = "Cake",
                Subhead = "News",
                Dateline = "29-01-2021",
                Image = "Assets/Food.png"
            });


            items.Add(new NewsItem()
            {
                ID = 7,
                Category = "Food",
                Headline = "Candy",
                Subhead = "News",
                Dateline = "29-01-2021",
                Image = "Assets/Food1.png"
            });

            items.Add(new NewsItem()
            {
                ID = 8,
                Category = "Food",
                Headline = "Socola",
                Subhead = "News",
                Dateline = "29-01-2021",
                Image = "Assets/Food2.png"
            });

            items.Add(new NewsItem()
            {
                ID = 9,
                Category = "Food",
                Headline = "Milk",
                Subhead = "News",
                Dateline = "29-01-2021",
                Image = "Assets/Food3.png"
            });

            items.Add(new NewsItem()
                {
                ID = 10,
                Category = "Food",
                Headline = "Rice",
                Subhead = "News",
                Dateline = "29-01-2021",
                Image = "Assets/Food4.png"
            });

            return items;
        }

        public class NewsManager
        {

            public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
            {
                var allItems = getNewsItems();

                var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();

                newsItems.Clear();

                filteredNewsItems.ForEach(p => newsItems.Add(p));

            }

        }

    }
        

           
        
}

    

    
      
        
          

    

