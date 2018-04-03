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
bits=randint(1,N)*2-1
nrzm=[];
marca=bits(1);
for n=1:N
    if(bits(n)==1)
        marca=-1*marca;
    end
    nrzm=[nrzm s1*marca];
end

figure(2);
subplot(2, 1, 1);
plot(t, nrzm);
title('Codigo');
axis([0, N -1.5 1.5]);
grid on;

% Espectro NRZ-M
N=300;
nrzm=[];
bits=randint(1,N)*2-1; %Quitamos corriente directa modificando los niveles
marca=bits(1);
for n=1:N
    if(bits(n)==1)
        marca=-1*marca;
    end
    nrzm=[nrzm s1*marca];
end
NRZM=fftshift(fft(nrzm,100000))*ts;
f=linspace(-1/(2*ts),1/(2*ts),length(NRZM));
figure(2);
subplot(2, 1, 2);
plot(f, abs(NRZM));
title('Espectro');
axis([-5 5 -0.5 max(abs(NRZM))]);
grid on;

%% NRZ-S


%% Machester
%s0=[zeros(1,50) ones(1,50)]
%s0=[ones(1,50) zeros(1,50)]
