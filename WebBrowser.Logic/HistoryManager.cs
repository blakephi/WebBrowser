﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.WebBrowserDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddItem(HistoryItem item)
        {
            var adapter = new historyTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date.ToString());
        }
        public static List<HistoryItem> GetItems()
        {
            var adapter = new historyTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = Convert.ToDateTime(row.Date);

                results.Add(item);
            }

            return results;
        }

        public static void ClearHistory()
        {
            var adapter = new historyTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                adapter.Delete(row.Id, row.URL, row.Title, row.Date);
            }
        }

        public static void DeleteSelected(string selected)
        {
            var adapter = new historyTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                string check = string.Format(string.Format("[{0}] {1} ({2})"), row.Date, row.Title, row.URL);

                if (check == selected)
                {
                    adapter.Delete(row.Id, row.URL, row.Title, row.Date);
                }
            }
        }
    }
}
