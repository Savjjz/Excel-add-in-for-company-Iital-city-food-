using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Windows.Forms;
using System.CodeDom;

namespace FirstExcel.Platforms.Goods.Products
{
    class Product
    {
        public string ProductType { get; private set; }
            
        public Product(string productType)
        {
            ProductType = productType;
        }

        public void FillDataInGoodsFile(string fileGoodsAddress)
        {
            List<string> AllData = GetDataFromFileXLSX();
            Globals.ThisAddIn.Application.Workbooks.Open(fileGoodsAddress);

            const int columnsNumber = 9;
            int currentLine = 4;
            string cellNumber = "";
            int counter = 0;

            for (int i = 0; i < AllData.Count; i++)
            {
                if (counter == columnsNumber)
                {
                    counter = 0;
                    currentLine++;
                }                    
                
                switch (counter)
                {
                    case 0:
                        cellNumber = "A" + Convert.ToString(currentLine);
                        break;
                    case 1:
                        cellNumber = "B" + Convert.ToString(currentLine);
                        break;
                    case 2:
                        cellNumber = "M" + Convert.ToString(currentLine);
                        break;
                    case 3:
                        cellNumber = "O" + Convert.ToString(currentLine);
                        break;
                    case 4:
                        cellNumber = "R" + Convert.ToString(currentLine);
                        break;
                    case 5:
                        cellNumber = "S" + Convert.ToString(currentLine);
                        break;
                    case 6:
                        cellNumber = "T" + Convert.ToString(currentLine);
                        break;
                    case 7:
                        cellNumber = "U" + Convert.ToString(currentLine);
                        break;
                    case 8:
                        cellNumber = "V" + Convert.ToString(currentLine);
                        break;
                }

                Excel.Range cell = Globals.ThisAddIn.Application.get_Range(cellNumber);
                cell.Value = AllData[i];
                counter++;
            }

        }

        private List<string> GetDataFromFileXLSX()
        {
            const int columnsNumber = 9;
            int currentLine = 2;
            string cellNumberName = "B" + Convert.ToString(currentLine);
            string cellNumberProductType = "A" + Convert.ToString(currentLine);
            Excel.Range cellName = Globals.ThisAddIn.Application.get_Range(cellNumberName);
            Excel.Range cellProductType = Globals.ThisAddIn.Application.get_Range(cellNumberProductType);

            List<string> AllData = new List<string>();

            while (cellName.Value != null)
            {
                if (Convert.ToString(cellProductType.Value) == ProductType)
                {
                    for (int j = 0; j < columnsNumber; j++)
                    {
                        string str;
                        switch (j)
                        {
                            case 0:
                                string _cellNumber = "R" + Convert.ToString(currentLine);
                                Excel.Range _cell = Globals.ThisAddIn.Application.get_Range(_cellNumber);
                                AllData.Add(Convert.ToString(_cell.Value));
                                break;
                            case 1:
                                _cellNumber = "E" + Convert.ToString(currentLine);
                                _cell = Globals.ThisAddIn.Application.get_Range(_cellNumber);
                                AllData.Add(Convert.ToString(_cell.Value));
                                break;
                            case 2:
                                _cellNumber = "B" + Convert.ToString(currentLine);
                                _cell = Globals.ThisAddIn.Application.get_Range(_cellNumber);
                                str = Convert.ToString(_cell.Value);
                                AllData.Add(SetNameInGoods(str));
                                break;
                            case 3:
                                AllData.Add("Casa Rinaldi");
                                break;
                            case 4:
                                _cellNumber = "D" + Convert.ToString(currentLine);
                                _cell = Globals.ThisAddIn.Application.get_Range(_cellNumber);
                                AllData.Add(Convert.ToString(_cell.Value));
                                break;
                            case 5:
                                _cellNumber = "L" + Convert.ToString(currentLine);
                                _cell = Globals.ThisAddIn.Application.get_Range(_cellNumber);
                                AllData.Add(Convert.ToString(_cell.Value));
                                break;
                            case 6:
                                _cellNumber = "P" + Convert.ToString(currentLine);
                                _cell = Globals.ThisAddIn.Application.get_Range(_cellNumber);
                                str = Convert.ToString(_cell.Value);
                                AllData.Add(FromMilimetersToCentimeters(str));
                                break;
                            case 7:
                                _cellNumber = "Y" + Convert.ToString(currentLine);
                                _cell = Globals.ThisAddIn.Application.get_Range(_cellNumber);
                                str = Convert.ToString(_cell.Value);
                                AllData.Add(FromMilimetersToCentimeters(str));
                                break;
                            case 8:
                                _cellNumber = "Q" + Convert.ToString(currentLine);
                                _cell = Globals.ThisAddIn.Application.get_Range(_cellNumber);
                                str = Convert.ToString(_cell.Value);
                                AllData.Add(FromMilimetersToCentimeters(str));
                                break;
                        }
                    }
                }

                currentLine++;
                cellNumberName = "B" + Convert.ToString(currentLine);
                cellNumberProductType = "A" + Convert.ToString(currentLine);
                cellName = Globals.ThisAddIn.Application.get_Range(cellNumberName);
                cellProductType = Globals.ThisAddIn.Application.get_Range(cellNumberProductType);
            }

            return AllData;
        }
        
        private string FromMilimetersToCentimeters(string numberInMilimeters)
        {
            string numberInCentimeters = numberInMilimeters;
            numberInCentimeters = numberInCentimeters.Insert(numberInCentimeters.Length - 1, ",");
            return numberInCentimeters;
        }

        private string SetNameInGoods(string nameIn1C)
        {
            string subString = "CR";
            string str = " ";
            string CR = " Casa Rinaldi";

            int indexOfSubString = nameIn1C.IndexOf(subString);
            int indexOfFirstSpace = nameIn1C.IndexOf(str);
            int k = 3;
            nameIn1C = nameIn1C.Remove(indexOfSubString, k);
            nameIn1C = nameIn1C.Insert(indexOfFirstSpace, CR);

            string nameInGoods = nameIn1C;
            return nameInGoods;
        }
    }
}
