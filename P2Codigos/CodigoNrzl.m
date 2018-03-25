function [ ] = CodigoNrzl(secuencia)
    n=1;
    %l=length(secuencia);
    %secuencia(l+1)=1;

    figure(1);  
    while (n<=length(secuencia)-1)
        t=n-1:0.001:n;
        if secuencia(n) == 0
            if secuencia(n+1)==0 
                y=(t>n);
            else
                y=(t==n);
            end
            plot(t,y);
            hold on;
            %disp('zero');
        else
            if secuencia(n+1)==0
                y=(t<n)-0*(t==n);
            else
                y=(t<n)+1*(t==n);
            end
            plot(t,y);
            hold on;
            %disp('one');
        end
    n=n+1;
    end
    grid on;
    title('NRZ-L');
end

