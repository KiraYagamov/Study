using System;
using System.Collections;
using System.Collections.Generic;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            MainVoids mv = new MainVoids();
            mv.MainVoid();
        }
    }
    public class MainVoids{
        List<int> delitels = new List<int>();
        int count = 0;
        int min = 0;
        int minNum;
        int c;
        bool is_prime(int x) {
            if(x <= 1) return false;
            int d = 2;
            while(d*d <= x){
                if(x%d == 0){
                    return false;
                }
                d += 1;
            }
            return true;
        }
        public void MainVoid(){
            for(int i = 153732; i <= 225674; i++){
                delitels.Add(2);
                for(int g = 3; g <= Math.Round(Math.Pow(i, 0.5f)); g += 2){
                    delitels.Add(g);
                }
                foreach(int x in delitels){
                    if(i%x == 0 && is_prime(x)){
                        c = i/x;
                        if(x != c && is_prime(c)){
                            count++;
                            if(min == 0){
                                min = Math.Abs(x-c);
                                minNum = i;
                            }
                            else if(min > Math.Abs(x-c)){
                                min = Math.Abs(x-c);
                                minNum = i;
                            }
                            break;
                        }
                    }
                }
                delitels.Clear();
            }
            Console.Write(count.ToString() + " " + minNum.ToString());
        }
    }
}