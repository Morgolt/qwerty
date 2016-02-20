using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRostelecom.DAO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data;
using System.Reflection;

namespace TestRostelecom.Export
{
    public class ExportToExcel
    {
        public void ExportToXLS<T>(IEnumerable<T> list, string path)
        {
            SpreadsheetDocument doc = SpreadsheetDocument.Create(path, SpreadsheetDocumentType.Workbook);
            WorkbookPart workbookpart = doc.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();
            WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());
            Sheets sheets = doc.WorkbookPart.Workbook.
                    AppendChild<Sheets>(new Sheets());
            Sheet sheet = new Sheet()
            {
                Id = doc.WorkbookPart.
                    GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "mySheet"
            };            
            sheets.Append(sheet);
            workbookpart.Workbook.Save();
            doc.Close();
        }

        private DataTable EnumerableToDataTable<T>(IEnumerable<T> list)
        {
            DataTable dt = new DataTable();

            foreach(PropertyInfo info in typeof(T).GetProperties())
            {
                dt.Columns.Add(new DataColumn(info.Name, info.PropertyType));
            }

            foreach(T t in list)
            {
                DataRow dr = dt.NewRow();

                foreach(PropertyInfo info in typeof(T).GetProperties())
                {
                    dr[info.Name] = info.GetValue(t, null); 
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
