using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FFCodeChallenge.DataInputHandler
{
    public class FormatPyramidData : IFormatPyramidData
    {
        public int[][] GetFormattedData(string fileToRead)
        {

            var linesInFile = GetLines(fileToRead);

            return FormatTriangleData(linesInFile, fileToRead);

        }

        private int GetLines(string fileWithLines)
        {
            var lines = File.ReadAllLines(fileWithLines);
            return lines.Length;
        }

        private int[][] FormatTriangleData(int linesInTriangle, string fileToRead)
        {
            int[][] triangle;
            string line;
            int counter = 0;

            StreamReader file = new StreamReader(fileToRead);

            triangle = new int[linesInTriangle][];
            while ((line = file.ReadLine()) != null)
            {
                string[] linePieces = line.Split(' ');

                int[] row = new int[linePieces.Length];
                for (int i = 0; i < linePieces.Length; i++)
                {
                    string a = linePieces[i];
                    row[i] = int.Parse(linePieces[i]);
                }
                triangle[counter] = row;
                counter++;
            }
            return triangle;
        }
    }
}
