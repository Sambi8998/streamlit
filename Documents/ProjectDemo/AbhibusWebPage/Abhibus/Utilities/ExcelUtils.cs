using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abhibus.Utilities
{
    internal class ExcelUtils
    {
        public static List<BookBusData> ReadExcelData(string excelFilePath, string sheetName)
        {
            List<BookBusData> excelDataList = new List<BookBusData>();
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true,
                        }
                    });

                    var dataTable = result.Tables[sheetName];

                    if (dataTable != null)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            BookBusData excelData = new BookBusData
                            {
                                
                                FromInput = GetValueOrDefault(row, "frominput"),
                                ToInput = GetValueOrDefault(row, "toinput"),
                                Date = GetValueOrDefault(row, "date"),
                                BusType = GetValueOrDefault(row, "bustype"),
                                Departure = GetValueOrDefault(row, "departure"),
                                Name = GetValueOrDefault(row, "name"),
                                Age = GetValueOrDefault(row, "age"),
                                Contact = GetValueOrDefault(row, "contact"),
                                Email = GetValueOrDefault(row, "email"),
                                
                                Pin = GetValueOrDefault(row, "pin"),  
                                State = GetValueOrDefault(row, "state"),
                                City = GetValueOrDefault(row, "city"),
                                //BusPartner = GetValueOrDefault(row, "buspartner"),
                                
                                //Adult = GetValueOrDefault(row, "adult"),
                                //TravelClass = GetValueOrDefault(row, "travelclass")
                            };

                            excelDataList.Add(excelData);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sheet '{sheetName}' not found in the Excel file.");
                    }
                }
            }

            return excelDataList;
        }

        static string GetValueOrDefault(DataRow row, string columnName)
        {
            Console.WriteLine(row + "  " + columnName);
            return row.Table.Columns.Contains(columnName) ? row[columnName]?.ToString() : null;
        }
    }
}
