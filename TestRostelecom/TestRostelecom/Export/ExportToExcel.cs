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
using System.Windows.Forms;

namespace TestRostelecom.Export
{
    public class ExportToExcel
    {
        public void ExportToXLS(DataGridView dgv, string path)
        {
            using (SpreadsheetDocument doc = SpreadsheetDocument.Create(path, SpreadsheetDocumentType.Workbook))
            {
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
                CreateWorkSheet(worksheetPart, dgv);
                workbookpart.Workbook.Save();
            }
        }        

        /*private void CreateWorkSheet(WorksheetPart worksheetPart, DataGridView dgv)
        {
            Worksheet worksheet = new Worksheet();
            SheetData sheetData = new SheetData();

            UInt32Value currRowIndex = 1U;
            int colIndex = 0;
            Row excelRow;

            foreach(DataGridViewRow row in dgv.Rows)
            {
                excelRow = new Row();
                excelRow.RowIndex = currRowIndex++;

                foreach(DataGridViewColumn col in dgv.Columns)
                {
                    Cell cell = new Cell();
                    CellValue cellValue = new CellValue();                    
                    cellValue.Text = row.Cells[colIndex].Value?.ToString();
                    cell.Append(cellValue);
                    excelRow.Append(cell);
                    colIndex++;
                }
                sheetData.Append(excelRow);
            }

            SheetFormatProperties formattingProps = new SheetFormatProperties()
            {
                DefaultRowHeight = 20D,
                DefaultColumnWidth = 20D
            };

            worksheet.Append(formattingProps);
            worksheet.Append(sheetData);
            worksheetPart.Worksheet = worksheet;
        }*/

        private void CreateWorkSheet(WorksheetPart worksheetPart, DataGridView dgv)
        {
            Worksheet worksheet = new Worksheet();
            SheetData sheetData = new SheetData();

            UInt32Value currRowIndex = 1U;
            Row excelRow = new Row();
            foreach(DataGridViewColumn col in dgv.Columns)
            {
                Cell cell = new Cell();
                cell.DataType = CellValues.String;
                CellValue cellValue = new CellValue();
                cellValue.Text = col.HeaderText;
                cell.Append(cellValue);
                excelRow.Append(cell);
            }
            sheetData.Append(excelRow);
            currRowIndex++;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                excelRow = new Row();
                excelRow.RowIndex = currRowIndex++;
                foreach (DataGridViewCell col in row.Cells)
                {
                    Cell cell = new Cell();
                    CellValue cellValue = new CellValue();
                    cell.DataType = CellValues.String;
                    cellValue.Text = col.Value?.ToString();
                    cell.Append(cellValue);
                    excelRow.Append(cell);                    
                }
                sheetData.Append(excelRow);
            }

            SheetFormatProperties formattingProps = new SheetFormatProperties()
            {
                DefaultRowHeight = 20D,
                DefaultColumnWidth = 20D
            };

            worksheet.Append(formattingProps);
            worksheet.Append(sheetData);
            worksheetPart.Worksheet = worksheet;
        }
    }
}
