using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace ServersConvertToReg
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string CSV_PATH = args.Length > 0 ? args[0] : "/path/to/your/default/file.csv";
            readCSV(CSV_PATH);
        }

        // Read the CSV file
        public static void readCSV(string CSV_PATH)
        {
            try
            {
                string data = "";
                foreach (var line in File.ReadLines(CSV_PATH))
                {
                    data += line + "\n";
                }

                // Split the data into rows
                string[] rows = data.Split('\n');

                string reg = "Windows Registry Editor Version 5.00\n\n";

                // Process each row
                for ( int r = 1; r == rows.Length; r++)
                {
                    string row = rows[r];
                    // Split the row into columns
                    string[] columns = row.Split(',');

                    reg += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Intersystems\\Cache\\Servers\\]";

                    // Process each column
                    foreach (string column in columns)
                    {
                        // Do something with the column value
                        reg += column + "\n";
                    }
                }
                Console.WriteLine(reg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
