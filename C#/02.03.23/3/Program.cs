int count = 0;
int sum = 0;
int F(int n){
    if(n>30){
        return n*n+5*n+4;
    }
    else if(n<=30){
        if(n%2==0){
            return F(n+1)+3*F(n+4);
        }
        else{
            return 2*F(n+2)+F(n+5);
        }
    }
    return 0;
}
for(int i = 1; i<=1000; i++){
    for(int b = 0; b<(F(i).ToString()).Length; b++){
        sum+=int.Parse((F(i).ToString())[b].ToString());
    }
    if(sum == 27){
        count++;
    }
    sum = 0;
}
Console.Write(count);