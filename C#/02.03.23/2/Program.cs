int count = 0;
int F(int n){
    if(n>20){
        return n*n*n+n;
    }
    else if(n<=20){
        if(n%2==0){
            return 3*F(n+1)+F(n+3);
        }
        else{
            return F(n+2)+2*F(n+3);
        }
    }
    return 0;
}
for(int i = 1; i<=1000; i++){
    for(int b = 0; b<(F(i).ToString()).Length; b++){
        if(int.Parse((F(i).ToString())[b].ToString()) == 1){
            count++;
            goto Next;
        }
    }
    Next:
    count = count;
}
Console.Write(1000-count);