using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace challengers_club_adventure
{
    class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            var backDiag = 0;
            var forwDiag = 0;
            
            for (int i = 0; i < arr.Count; i++) {
                backDiag += arr[i][i];
            }
            
            int j = 0;
            for (int i = arr.Count - 1; i >= 0 && j < arr.Count; i--, j++) {
                forwDiag += arr[i][j];
            }
            
            return Math.Abs(backDiag - forwDiag);
        }

    }

    public class Diagonal_Difference
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}