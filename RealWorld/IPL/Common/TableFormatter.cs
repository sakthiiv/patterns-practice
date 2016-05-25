using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.IPL.Common
{
    public class TableFormatter<T> : IFormatter<T>
    {
        private string[] _headers;

        public TableFormatter(string[] headers)
        {
            _headers = headers;
        }

        public void Format(IEnumerable<T> values, params Func<T, object>[] selectors)
        {
            var arrValues = values.ToArray();
            var arrTable = new string[arrValues.Length + 1, selectors.Length];

            for (int colIndex = 0; colIndex < arrTable.GetLength(1); colIndex++)
            {
                arrTable[0, colIndex] = _headers[colIndex];
            }

            for (int rowIndex = 1; rowIndex < arrTable.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < arrTable.GetLength(1); colIndex++)
                {
                    arrTable[rowIndex, colIndex] = selectors[colIndex]
                      .Invoke(arrValues[rowIndex - 1]).ToString();

                }
            }

            Console.Write(ToStringTable(arrTable));
        }

        private string ToStringTable(string[,] arrValues)
        {
            int[] maxColumnsWidth = GetMaxColumnsWidth(arrValues);
            var headerSpliter = new string('-', maxColumnsWidth.Sum(i => i + 3) - 1);

            var sb = new StringBuilder();
            for (int rowIndex = 0; rowIndex < arrValues.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < arrValues.GetLength(1); colIndex++)
                {
                    string cell = arrValues[rowIndex, colIndex];
                    cell = cell.PadRight(maxColumnsWidth[colIndex]);
                    sb.Append(" | ");
                    sb.Append(cell);
                }

                sb.Append(" | ");
                sb.AppendLine();

                if (rowIndex == 0)
                {
                    sb.AppendFormat(" |{0}| ", headerSpliter);
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }

        private int[] GetMaxColumnsWidth(string[,] arrValues)
        {
            var maxColumnsWidth = new int[arrValues.GetLength(1)];
            for (int colIndex = 0; colIndex < arrValues.GetLength(1); colIndex++)
            {
                for (int rowIndex = 0; rowIndex < arrValues.GetLength(0); rowIndex++)
                {
                    int newLength = arrValues[rowIndex, colIndex].Length;
                    int oldLength = maxColumnsWidth[colIndex];

                    if (newLength > oldLength)
                    {
                        maxColumnsWidth[colIndex] = newLength;
                    }
                }
            }

            return maxColumnsWidth;
        }
    }
}
