﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.WebBrowserDataSetTableAdapters;

namespace WebBrowser.Logic
{
    class HistoryManager
    {
        public static void AddItem (HistoryItem item)
        {
            var adapter = new historyTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date);
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
    }
}
