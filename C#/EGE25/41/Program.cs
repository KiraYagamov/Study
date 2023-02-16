using System;
using System.Collections.Generic;
namespace Program{
    class Program{
        static void Main(string[] args){
            MainProgram mp = new MainProgram();
            mp.StartProgram();
        }
    }
    public class MainProgram{
        public void StartProgram(){
            List<int> delitels = new List<int>();
            int num = 0;
            for(int i = 4671032; i <= 4671106; i++){
                num++;
                for(int b = 1; b <= i; b++){
                    if(i%b == 0){
                        delitels.Add(b);
                    }
                }
                if(delitels.Count == 2){
                    Console.WriteLine(num.ToString() + " " + i.ToString());
                }
                delitels.Clear();
            }
        }
    }
}