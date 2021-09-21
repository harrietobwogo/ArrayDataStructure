using System;
using System.Collections.Generic;
class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
		int[][] matrix = new int[][] 
{
    new int[] {1, 2, 3},
    new int[] {11, 34, 67},
    new int[] {89, 23,9},
    new int[] {0, 45, 99}
};
var result=SpiralOrder(matrix);
Console.WriteLine(string.Join(",",result));
  }
	public static IList<int> SpiralOrder(int[][] matrix) {
        var result=new List<int>();
        if(matrix.Length==0){
            return result;
        }
        int startRow=0;
        int endRow=matrix.Length-1;
        int startCol=0;       
        int endCol=matrix[0].Length-1;
        while(startRow<=endRow && startCol<=endCol){            
            for(int i=startCol; i<=endCol; i++){
                result.Add(matrix[startRow][i]);
            }
            for(int i=startRow+1; i<=endRow; i++){
                result.Add(matrix[i][endCol]);
            }
            for(int i=endCol-1; i>=startCol; i--){
                if(startRow==endRow)break;
                result.Add(matrix[endRow][i]);
            }
            for(int i=endRow-1; i>startRow; i--){
                if(startCol==endCol)break;
                result.Add(matrix[i][startCol]);
            }
            startRow++;
            endRow--;
            startCol++;
            endCol--;
         }     
     return result; 
    }
}