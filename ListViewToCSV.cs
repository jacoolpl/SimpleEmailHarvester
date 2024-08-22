using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEmailHarvester
{
    public static class ListViewToCSVNew
    {
        public static void ListViewToCSV(ListView listView, string filePath, bool includeHidden)
        {
            // Create the header
            StringBuilder result = new StringBuilder();
            WriteCSVRow(result, listView.Columns.Count,
                i => includeHidden || listView.Columns[i].Width > 0,
                i => listView.Columns[i].Text);

            // Export data rows
            foreach (ListViewItem listItem in listView.Items)
                WriteCSVRow(result, listView.Columns.Count,
                    i => includeHidden || listView.Columns[i].Width > 0,
                    i => listItem.SubItems[i].Text);

            // Write to the file
            File.WriteAllText(filePath, result.ToString());
        }

        private static void WriteCSVRow(StringBuilder result, int itemsCount,
                                        Func<int, bool> isColumnNeeded, Func<int, string> columnValue)
        {
            bool isFirstTime = true;
            for (int i = 0; i < itemsCount; i++)
            {
                if (!isColumnNeeded(i)) continue;
                if (!isFirstTime) result.Append(",");
                isFirstTime = false;
                result.Append($"\"{columnValue(i)}\"");
            }
            result.AppendLine();
        }
    }
}
