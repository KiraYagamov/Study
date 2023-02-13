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
        int count;
        int maxNum;
        public void MainVoid(){
            for(int i = 125697; i <= 190234; i++){
                for(int b = 2; b <= i; b++){
                    if(i%b == 0){
                        delitels.Add(b);
                    }
                }
                for(int b = 0; b < delitels.Count; b++){
                    for(int c = 0; c < delitels.Count; c++){
                        if(i == delitels[b]*delitels[c] && delitels[b] != delitels[c]){
                            count += 1;
                            maxNum = i;
                            goto Next;
                        }
                    }
                }
                Next:
                delitels.Clear();
            }
            Console.Write(count.ToString() + " " + maxNum.ToString());
        }
    }
}