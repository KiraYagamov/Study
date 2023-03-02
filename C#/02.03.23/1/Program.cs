int count = 0;
int F(int n){
    if(n>25){
        return 2*n*n*n+1;
    }
    else if(n<=25){
        return F(n+2)+2*F(n+3);
    }
    return 0;
}
for(int i = 1; i<=1000; i++){
    if(F(i)%11 == 0){
        count++;
    }
}
Console.Write(count);