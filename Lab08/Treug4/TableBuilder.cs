using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treug4
{
    internal class TableBuilder
    {
        // what table represents, column with header, column width, row with data
        private List<string> headers;
        private List<List<string>> rows;
        private List<int> widths;

        // build table
        public TableBuilder()
        {
            headers = new List<string>();
            rows = new List<List<string>>();
            widths = new List<int>();
        }

        // set columns header and width
        public void AddHeader(params string[] header)
        {
            headers = new List<string>(header); // pass set of headers
            widths = new List<int>();
            // save headers
            foreach (var item in header)
            {
                widths.Add(item.Length);
            }
        }

        // add rows which meet headers 1=1 and width
        public void AddRow(params string[] row)
        {
            // save headers
            var rowdata = new List<string>(); // List<string>?

            // add empty header
            for (int i = 0; i < headers.Count; i++)
            {
                //Console.WriteLine($"DEBUG: Headers count: {headers.Count}, Current row count: {rowdata.Count}");
                rowdata.Add(i < row.Length ? row[i] : ""); // check if row cell with data ? true add cell data : false add empty data
            }
            rows.Add(rowdata);

            // update widths to widest
            for (int i = 0; i < headers.Count; i++)
            {
                //Console.WriteLine($"DEBUG: Headers count: {headers.Count}, Current row count: {rowdata.Count}");
                widths[i] = Math.Max(widths[i], rowdata[i].Length); // compare width to element max width
            }
        }

        // add divider
        private void AddDivider()
        {
            foreach (var item in widths)
            {
                string line = new string('-', item + 2); // generate string, unicode number of times, add offset
                Console.Write("+" + line); //start
            }
            Console.WriteLine("+"); //end
        }

        // add row with data
        private void AddRowData(List<string> rowdata)
        {
            for (int i = 0; i < rowdata.Count; i++)
            {
                Console.Write("| " + rowdata[i].PadRight(widths[i]) + " ");  //start, alight to right by spaces
            }
            Console.WriteLine("|"); //end
        }

        // print table with borders
        public void PrintTable()
        {
            AddDivider();
            AddRowData(headers); // table header
            AddDivider();

            foreach (var item in rows)
            {
                AddRowData(item); // rows with data
            }
            AddDivider();
        }
    }
}
