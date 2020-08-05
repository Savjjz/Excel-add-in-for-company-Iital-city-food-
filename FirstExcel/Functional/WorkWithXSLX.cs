using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace FirstExcel.Functional
{
    public static class WorkWithXSLX
    {

        /// <summary>
        /// Поиск ID недостающих товаров из файла 1С в файле платформы
        /// </summary>
        /// <param name="File1C">Адрес рабочего файла 1C</param>
        /// <param name="FilePlatform">Адрес рабочего файла платформы</param>
        public static List<int> FindDivideInFiles(string FileDir1C, string FileDirPlatform)
        {
            List<int> Id_1C = new List<int>();              //Список всех ID в таблице 1C
            List<int> Id_Platform = new List<int>();        //Список всех ID в таблице платформы
            List<int> Id_Divide = new List<int>();          //ID из 1C, которых нет в таблице платформы

            Globals.ThisAddIn.Application.Workbooks.Open(FileDirPlatform);

            int currentLinePlatform = 2;
            string currentCellNumberPlatform = "B" + Convert.ToString(currentLinePlatform);
            Excel.Range currentCellPlatform = Globals.ThisAddIn.Application.get_Range(currentCellNumberPlatform);

            while (currentCellPlatform.Value != null)
            {
                Id_Platform.Add(Convert.ToInt32(currentCellPlatform.Value));
                currentLinePlatform++;
                currentCellNumberPlatform = "B" + Convert.ToString(currentLinePlatform);
                currentCellPlatform = Globals.ThisAddIn.Application.get_Range(currentCellNumberPlatform);
            }


            Globals.ThisAddIn.Application.Workbooks.Open(FileDir1C);

            int currentLine1C = 9;
            string currentCellNumber1C = "C" + Convert.ToString(currentLine1C);
            string currentCellNumberId1C = "S" + Convert.ToString(currentLine1C);
            Excel.Range currentCell1C = Globals.ThisAddIn.Application.get_Range(currentCellNumber1C);
            Excel.Range currentCellId1C = Globals.ThisAddIn.Application.get_Range(currentCellNumberId1C);

            while (currentCell1C.Value != null)
            {
                if (Convert.ToInt32(currentCellId1C.Value) != 0)
                    Id_1C.Add(Convert.ToInt32(currentCellId1C.Value));
                currentLine1C++;
                currentCellNumber1C = "C" + Convert.ToString(currentLine1C);
                currentCellNumberId1C = "S" + Convert.ToString(currentLine1C);
                currentCell1C = Globals.ThisAddIn.Application.get_Range(currentCellNumber1C);
                currentCellId1C = Globals.ThisAddIn.Application.get_Range(currentCellNumberId1C);
            }

            Id_Divide = ListDivergence(Id_1C, Id_Platform);

            return Id_Divide;
        }

        /// <summary>
        /// Найти и записать в массив строки из таблицы по Id
        /// </summary>
        /// <param name="ListId">Список Id</param>
        /// <param name="FileDir1C">Адрес рабочего файла 1C</param>
        /// <returns></returns>
        public static string[,] FindLinesInTableById(List<int> ListId)
        {
            const int lineLength = 24;
            string[,] Data = new string[ListId.Count, lineLength];

            int currentLine = 9;
            string cellNumberName = "C" + Convert.ToString(currentLine);
            string cellNumberId = "S" + Convert.ToString(currentLine);
            Excel.Range cellName = Globals.ThisAddIn.Application.get_Range(cellNumberName);
            Excel.Range cellId = Globals.ThisAddIn.Application.get_Range(cellNumberId);
            int counter = 0;

            while (cellName.Value != null)
            {
                if (cellId.Value != null)
                {
                    foreach (int i in ListId)
                    {
                        if (Convert.ToInt32(cellId.Value) == i)
                        {
                            for (int j = 0; j < lineLength; j++)
                            {
                                int k = 67 + j;
                                string _cellNum = Convert.ToString((char)k) + Convert.ToString(currentLine);
                                Excel.Range _cell = Globals.ThisAddIn.Application.get_Range(_cellNum);
                                Data[counter, j] = Convert.ToString(_cell.Value);
                            }
                            counter++;
                        }
                    }
                }

                currentLine++;
                cellNumberName = "C" + Convert.ToString(currentLine);
                cellNumberId = "S" + Convert.ToString(currentLine);
                cellName = Globals.ThisAddIn.Application.get_Range(cellNumberName);
                cellId = Globals.ThisAddIn.Application.get_Range(cellNumberId);
            }

            return Data;
        }
  
        /// <summary>
        /// Записать в новую книгу матрицу данных из 1С
        /// </summary>
        /// <param name="Data">матрица расхождений между 1С и Goods</param>
        public static void WriteInNewWorkbook(string[,] Data)
        {
            Excel.Workbook workbook = Globals.ThisAddIn.Application.Workbooks.Add();
            int currentLine = 2;

            for (int i = 0; i < Data.GetLength(0); i++)
            {
                for (int j = 0; j < Data.GetLength(1); j++)
                {
                    int k = j + 66;
                    string cellNumber = Convert.ToString((char)k) + Convert.ToString(currentLine);
                    Excel.Range cell = Globals.ThisAddIn.Application.get_Range(cellNumber);
                    cell.Value = Data[i, j];
                }
                currentLine++;
            }

            string str = "Консервированные супы; " + "Консервы грибные; " + "Консервы овощные; " + "Консервы фруктовые; " +
                        "Оливки, маслины; Паштет; Урбеч, хумус, тапенад, диетическая ореховая паста; " + "Бобовые; " + "Крупа; " + "Лапша; " +
                        "Макаронные изделия; " + "Мука; " + "Масло растительное; " + "Варенье, ягоды с сахаром, пюре, десерты; " +
                        "Джем, конфитюр, повидло; " + "Мед; " + "Ореховая паста; " + "Шоколадно-ореховая паста; " + "Орехи; " + "Семечки; " +
                        "Сухофрукты, ягоды, цукаты; " + "Сушеные, вяленые овощи и грибы; " + "Десертный соус; " + "Сироп, пекмез; " + "Сахар; " +
                        "Соль; " + "Специи и приправы; " + "Горчица, хрен; " + "Заправка для салата; " + "Кетчуп; " + "Маринад; " + "Соусы; " +
                        "Томатная паста; " + "Уксус; " + "Кофе зерновой и молотый; " + "Кофе растворимый; " + "Цикорий и злаковые напитки; " +
                        "Чай; " + "Диетическая крупа, макароны, бобовые, клетчатка, отруби; " + "Диетические напитки; " + "Диетические снеки; " +
                        "Злаковые батончики, фруктово-ореховые батончики, мюсли; " + "Листья нори, сушеная морская капуста; " + "Мюсли, гранола; " +
                        "Овощные и фруктовые чипсы; " + "Печенье; " + "Нуга, щербет, халва; " + "Конфеты шоколадные, наборы, драже; " +
                        "Шоколад и шоколадные изделия, фигурки, батончики; " + "Мармелад; " + "Пастила";

            for (int i = 2; i < 2 + Data.GetLength(0); i++)
            {
                string cellNumber = "A" + Convert.ToString(i);
                Excel.Range cell = Globals.ThisAddIn.Application.get_Range(cellNumber);
                cell.Validation.Add(XlDVType.xlValidateList, XlDVAlertStyle.xlValidAlertStop, XlFormatConditionOperator.xlBetween, str);
            }

            Globals.ThisAddIn.Application.ActiveSheet.Columns.AutoFit();
            Globals.ThisAddIn.Application.ActiveSheet.Rows.AutoFit();
        }

        private static List<int> ListDivergence(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            bool isIn = false;

            foreach (int i in list1)
            {
                foreach (int j in list2)
                {
                    if (i == j)
                    {
                        isIn = true;
                        break;
                    }
                }
                if (!isIn)
                    result.Add(i);
                isIn = false;
            }

            return result;
        }

        private static void FillInFileGOODS()
        {

        }
    }
}


