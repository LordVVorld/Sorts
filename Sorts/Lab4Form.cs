using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Linq;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;

namespace Sorts
{
    public partial class Lab4Form : Form
    {
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";

        public Lab4Form()
        {
            InitializeComponent();
        }

        async private void LaunchButton_click(object sender, EventArgs e)
        {
            try
            {
                int[] array = new int[sortingArrayGrid.RowCount];
                for (int index = 0; index < sortingArrayGrid.RowCount; ++index)
                {
                    array[index] = int.Parse(sortingArrayGrid[0, index].Value.ToString());
                }
                
                if (sortingsChoose.CheckedItems.Contains(sortingsChoose.Items[0]))
                {
                    await Task.Run(() => BubbleSort.Sort(array));
                }
                if (sortingsChoose.CheckedItems.Contains(sortingsChoose.Items[1]))
                {
                    await Task.Run(() => InsertionSort.Sort(array));
                }
                if (sortingsChoose.CheckedItems.Contains(sortingsChoose.Items[2]))
                {
                    await Task.Run(() => ShakerSort.Sort(array));
                }
                if (sortingsChoose.CheckedItems.Contains(sortingsChoose.Items[3]))
                {
                    await Task.Run(() => QuickSort.Sort(array));
                }
                if (sortingsChoose.CheckedItems.Contains(sortingsChoose.Items[4]))
                {
                    await Task.Run(() => BOGO.Sort(array));
                }
            }
            catch
            {
              
            }
        }



        private void CloseButton_click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ExcelImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog excelFile = new OpenFileDialog())
            {
                DialogResult result = excelFile.ShowDialog();
                if (result == DialogResult.OK && Path.GetExtension(excelFile.FileName) == ".xlsx")
                {
                    Microsoft.Office.Interop.Excel.Application objExcel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook objWorkBook = objExcel.Workbooks.Open(excelFile.FileName);
                    Worksheet objWorkSheet = (Worksheet)objWorkBook.Sheets[1];

                    Range xRange = objWorkSheet.UsedRange.Columns[1];
                    Range yRange = objWorkSheet.UsedRange.Columns[2];

                    Array xCells = (Array)xRange.Cells.Value2;
                    Array yCells = (Array)yRange.Cells.Value2;

                    string[] xColumn = xCells.OfType<object>().Select(o => o.ToString()).ToArray();
                    string[] yColumn = yCells.OfType<object>().Select(o => o.ToString()).ToArray();

                    for (int index = 0; index < xRange.Cells.Count; ++index)
                    {
                        sortingArrayGrid.Rows.Add();
                        sortingArrayGrid.Rows[index].Cells[0].Value = xColumn[index];
                        sortingArrayGrid.Rows[index].Cells[1].Value = yColumn[index];
                    }

                    objWorkBook.Close();
                    objExcel.Quit();
                }
                else if (result == DialogResult.OK)
                {
                    MessageBox.Show("Ошибка!", "Неверное расширение файла.");
                }
            }
        }



        private void googleSheetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserCredential credential;

            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = "1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms";
            String range = "Class Data!A2:E";
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);

            // Prints the names and majors of students in a sample spreadsheet:
            // https://docs.google.com/spreadsheets/d/1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms/edit
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                Console.WriteLine("Name, Major");
                foreach (var row in values)
                {
                    // Print columns A and E, which correspond to indices 0 and 4.
                    Console.WriteLine("{0}, {1}", row[0], row[4]);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
            Console.Read();
        }
    }
}
