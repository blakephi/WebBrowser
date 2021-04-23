using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data;
using WebBrowser.Data.WebBrowserDataSetTableAdapters;
using static WebBrowser.Data.WebBrowserDataSet;


namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.Title, item.URL);
        }

        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();
            var results = new List<BookmarkItem>();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;

                results.Add(item);
            }

            return results;
        }

        public static void DeleteBookmark(string selected)
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                string check = string.Format(string.Format("{0} ({1})", row.URL, row.Title));

                if (check == selected)
                {
                    adapter.Delete(row.Id, row.Title);
                }
            }
        }

        public static BookmarksDataTable BookmarkData()
        {
            var adapter = new BookmarksTableAdapter();
            return adapter.GetData();
        }
    }
}
