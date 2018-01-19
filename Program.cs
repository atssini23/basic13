using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            One();
            Two();
            Three();
            int[] X = new int[6] {1,3,5,7,9,13};
            Four(X);
            Five(X);
            Six(X);
            Seven();
            int[] F = new int[4] {1, 3, 5, 7};
            int y = 3;
            Eight(F, y);
            int [] V = new int [4] {1, 5, 10, -2};
            Nine(V);
            Ten(V);
            Eleven(V);
            int [] L = new int [4] {1, 5, 10, -2};
            Twelve(L);
            int [] W = new int [3] {-1, -3, 2};
            Thirteen(W);

        }
        static void One(){
            for (int i = 1; i <= 255; i++){
            //System.Console.WriteLine(i);
            }
        }
        static void Two(){
            for (int j = 1; j <= 255; j++){
            if ( j % 2 != 0 ){
                //System.Console.WriteLine(j);
                }
            }
        }
        static void Three(){
            int sum = 0;
            for (int a = 0; a <= 255; a++){
            sum += a;
               //System.Console.WriteLine($"New Number: {a} Sum: {sum}");
            }
        }
        static void Four(int[] arr){
            string brace= "[";
            for (int d = 0; d < arr.Length; d++){
            brace += arr[d] + ",";
            }
            brace += "]";
            //System.Console.WriteLine(brace);
        }
        static void Five(int[] arr){
            int max = arr[0];
            for(int s = 0; s < arr.Length; s++){
                if(arr[s] > max){
                    max = arr[s];
                }
            }
            //System.Console.WriteLine(max);
        }
        static void Six(int[] arr){
            int sum = 0;
            for(int q = 0; q < arr.Length; q++){
                sum += arr[q];
            }
            int avg = sum / arr.Length;
            //System.Console.WriteLine(avg);
        }
        static void Seven(){
            string brace = "[";
            for(int t = 0; t <= 255; t++){
                if( t % 2 != 0){
                    brace += t + ",";
                }
            }
            brace += "]";
            //System.Console.WriteLine(brace);
        }
        static void Eight(int[] arr, int y){
            int count = 0;
            foreach(int val in arr){
                if ( val > y){
                    count++;
                }
            }
            //System.Console.WriteLine($"There is {count} numbers greater than {y}");
        }
        static void Nine(int[] arr){
            for (int u = 0; u < arr.Length; u++){
                arr[u] *= arr[u];
            }
            //System.Console.WriteLine(string.Join(", ", arr));
        }
        static void Ten(int[] arr){
            for(int p = 0; p < arr.Length; p++){
                if( arr[p] < 0){
                    arr[p] = 0;
                }
            }
            //System.Console.WriteLine(string.Join(", " , arr));
        }
        static void Eleven(int[] arr){
            int min = 0;
            int max = 0;
            int sum = 0;
            for(int m = 0; m < arr.Length; m++){
                if(arr[m] < min){
                    min = arr[m];
                }
                 if(arr[m] > max){
                    max= arr[m];
                }
                sum += arr[m];
            }
            int avg = sum/ arr.Length;
            //System.Console.WriteLine($"{min}, {max}, {avg}");
        }
        static void Twelve(int[] arr){
            for( int n =0; n < arr.Length; n++){
                if (n < arr.Length - 1){
                    arr[n] = arr[n + 1];
                }
                else{
                    arr[n] = 0;
                }
            }
            //System.Console.WriteLine(string.Join(", ", arr));
        }
        static void Thirteen(int[] arr){
            string brace = "[";
            foreach(int var in arr){
                if( var < 0){
                    brace += "'Dojo',";
                }
                else{
                    brace += var ;
                }
            }
            brace += "]";
            System.Console.WriteLine(brace);

        }
    }
}
