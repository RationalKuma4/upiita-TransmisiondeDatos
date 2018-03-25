clear all;
close all;

ts=1/100;
Tb=1;
%N=20;
N=10;
t=0:ts:N*Tb-ts;

%% NRZ-L
s1=ones(1,100);
bits=randint(1,N)*2-1;
nrzl=[];
for n=1:N
    nrzl=[nrzl s1*bits(n)];
end
figure(1);
subplot(2, 1, 1);
plot(t, nrzl);
title('Codigo');
axis([0, N -1.5 1.5]);
grid on;
% Espectro NRZL
N=300;
nrzl=[];
bits=randint(1,N)*2-1; %Quitamos corriente directa modificando los niveles
for n=1:N
    nrzl=[nrzl s1*bits(n)];
end
NRZL=fftshift(fft(nrzl,100000))*ts;
f=linspace(-1/(2*ts),1/(2*ts),length(NRZL));
figure(1);
subplot(2, 1, 2);
plot(f, abs(NRZL));
title('Espectro');
axis([-5 5 -0.5 max(abs(NRZL))]);
grid on;

%% NRZ-M
N=10;
s1=ones(1,100);
bits=randint(1,N)*2-1;
marca=bits(1);
nrzm=[];
for n=1:N
    
    nrzm=[nrzm s1*bits(n)];
end

figure(2);
subplot(2, 1, 1);
plot(t, nrzm);
title('Codigo');
axis([0, N -1.5 1.5]);
grid on;

% Espectro NRZM
N=300;
nrzm=[1];
bits=randint(1,N)*2-1; %Quitamos corriente directa modificando los niveles
for n=1:N
    if((n-1)==0)
        nrzm=[nrzm s1*bits(n)];
    else
        nrzm=[nrzm s1*bits(n)];
    end
end
NRZM=fftshift(fft(nrzm,100000))*ts;
f=linspace(-1/(2*ts),1/(2*ts),length(NRZM));

figure(2);
subplot(2, 1, 2);
plot(f, abs(NRZM));
title('Espectro');
axis([-5 5 -0.5 max(abs(NRZM))]);
grid on;

%% Machester
%s0=[zeros(1,50) ones(1,50)]
%s0=[ones(1,50) zeros(1,50)]
