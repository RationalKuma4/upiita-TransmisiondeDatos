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
title('Codigo NRZ-L');
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
subplot(2, 1, 2);
plot(f, abs(NRZL));
title('Espectro');
axis([-5 5 -0.5 max(abs(NRZL))]);
grid on;

%% NRZ-M
N=10;
s1=ones(1,100);
bits=randint(1,N)*2-1;
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
title('Codigo NRZ-M');
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
subplot(2, 1, 2);
plot(f, abs(NRZM));
title('Espectro');
axis([-5 5 -0.5 max(abs(NRZM))]);
grid on;

%% NRZ-S
N=10;
s1=ones(1,100);
bits=randint(1,N)*2-1;
nrzs=[];
marca=bits(1);
for n=1:N
    if(bits(n)==-1)
        marca=-1*marca;
    end
    nrzs=[nrzs s1*marca];
end
figure(3);
subplot(2, 1, 1);
plot(t, nrzs);
title('Codigo NRZ-S');
axis([0, N -1.5 1.5]);
grid on;

% Espectro NRZ-S
N=300;
nrzs=[];
bits=randint(1,N)*2-1; %Quitamos corriente directa modificando los niveles
marca=bits(1);
for n=1:N
    if(bits(n)==1)
        marca=-1*marca;
    end
    nrzs=[nrzs s1*marca];
end
NRZS=fftshift(fft(nrzs,100000))*ts;
f=linspace(-1/(2*ts),1/(2*ts),length(NRZS));
subplot(2, 1, 2);
plot(f, abs(NRZS));
title('Espectro');
axis([-5 5 -0.5 max(abs(NRZS))]);
grid on;

%% RZ
N=10;
s1=ones(1,100);
bits=randint(1,N)*2-1;
rz=[];
for n=1:N
    if(bits(n)==1)
        rz=[rz s1(1:50)*bits(n)];
        rz=[rz s1(51:100)*-bits(n)];
    else
        rz=[rz s1(1:50)*bits(n)];
        rz=[rz s1(51:100)*bits(n)];
    end
end
figure(4);
subplot(2, 1, 1);
plot(t, rz);
title('Codigo RZ');
axis([0, N -1.5 1.5]);
grid on;

% Espectro RZ
N=300;
rz=[];
bits=randint(1,N)*2-1; %Quitamos corriente directa modificando los niveles
for n=1:N
    if(bits(n)==1)
        rz=[rz s1(1:50)*bits(n)];
        rz=[rz s1(51:100)*-bits(n)];
    else
        rz=[rz s1*bits(n)];
    end
end
RZ=fftshift(fft(rz,100000))*ts;
f=linspace(-1/(2*ts),1/(2*ts),length(RZ));
subplot(2, 1, 2);
plot(f, abs(RZ));
title('Espectro');
axis([-5 5 -0.5 max(abs(RZ))]);
grid on;

%% Bipolar
N=10;
s1=ones(1,100);
bits=randint(1,N)*2-1;
%bits=[1 -1 -1 1 -1 -1 1 1 1 -1 -1 -1 1]
bp=[];
if(bits(1))
    pico='a';
else
    pico='b';
end

for n=1:N
    if(bits(n)==1)
        if(pico=='a')
            bp=[bp s1(1:50)*bits(n)];
            bp=[bp s1(51:100)*0];
            pico='b';
        else
            bp=[bp s1(1:50)*-bits(n)];
            bp=[bp s1(51:100)*0];
            pico='a';
        end
    else
        bp=[bp s1*0];
    end
end
figure(5);
subplot(2, 1, 1);
plot(t, bp);
title('Codigo Bipolar');
axis([0, N -1.5 1.5]);
grid on;

% Espectro Bipolar
N=300;
bits=randint(1,N)*2-1; %Quitamos corriente directa modificando los niveles
bp=[];

if(bits(1))
    pico='a';
else
    pico='b';
end

for n=1:N
    if(bits(n)==1)
        if(pico=='a')
            bp=[bp s1(1:50)*bits(n)];
            bp=[bp s1(51:100)*0];
            pico='b';
        else
            bp=[bp s1(1:50)*-bits(n)];
            bp=[bp s1(51:100)*0];
            pico='a';
        end
    else
        bp=[bp s1*0];
    end
end
BP=fftshift(fft(bp,100000))*ts;
f=linspace(-1/(2*ts),1/(2*ts),length(BP));
subplot(2, 1, 2);
plot(f, abs(BP));
title('Espectro');
axis([-5 5 -0.5 max(abs(BP))]);
grid on;

%% Manchester
N=10;
s1=[ones(1,50) -1*ones(1,50)];
bits=randint(1,N)*2-1;
manchester=[];
for n=1:N
    manchester=[manchester s1*bits(n)];
end

figure(6);
subplot(2, 1, 1);
plot(t, manchester);
title('Codigo Manchester');
axis([0, N -1.5 1.5]);
grid on;

% Espectro Manchester
N=300;
nrzl=[];
bits=randint(1,N)*2-1; %Quitamos corriente directa modificando los niveles
for n=1:N
    manchester=[manchester s1*bits(n)];
end
MANCHESTER=fftshift(fft(manchester,100000))*ts;
f=linspace(-1/(2*ts),1/(2*ts),length(MANCHESTER));
subplot(2, 1, 2);
plot(f, abs(MANCHESTER));
title('Espectro');
axis([-5 5 -0.5 max(abs(MANCHESTER))]);
grid on;

%% Bifase Marca


%% Machester
%s0=[zeros(1,50) ones(1,50)]
%s1=[ones(1,50) zeros(1,50)]
