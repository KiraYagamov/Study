var cep, last:string; curCount, count, i: integer;
begin
  Readln(cep);
  count := 0;
  curCount := 0;
  last := '';
  for i:=1 to cep.Length do begin
    if last <> '' then begin
      if cep[i] > last then begin
        curCount+=1;
      end
      else begin
        if curCount > count then
          count := curCount;
        curCount := 0;
      end;
    end;
    last := cep[i];
  end;
  if curCount > count then
      count := curCount;
  print(count+1);
end.