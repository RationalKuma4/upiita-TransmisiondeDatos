function y=SecGold()
    sec1=[1 1 1 1 1];
    sec2=[1 1 1 1 1];
    %36
    for n=6:31
        sec1(n)=xor(sec1(n-5),sec1(n-3));
        
        a=xor(sec2(n-5),sec2(n-4));
        b=xor(a,sec2(n-3));
        c=xor(b,sec2(n-2));
        sec2(n)=c;
    end
    
    for n=1:31
        y{n}=xor(sec1,sec2);
        sec2=[sec2(2:31) sec2(1)];
    end
end