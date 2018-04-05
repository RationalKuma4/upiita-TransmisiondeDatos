clc;
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
set(gca,'xticklabel',bits.')
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
set(gca,'xticklabel',bits.')
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
set(gca,'xticklabel',bits.')
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
set(gca,'xticklabel',bits.')
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
set(gca,'xticklabel',bits.')
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
set(gca,'xticklabel',bits.')
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
N=10;
s1=[ones(1,50) -1*ones(1,50)];
s2=ones(1,100);
bits=randint(1,N)*2-1;
bfm=[];
marca=bits(1);
for n=1:N
    marca=-1*marca;
    if(bits(n)==1)
        bfm=[bfm s1*bits(n)*marca];
        marca=-1*marca;
    else
        bfm=[bfm s2*marca];
    end
end
figure(7);
subplot(2, 1, 1);
plot(t, bfm);
title('Codigo Bifase Marca');
axis([0, N -1.5 1.5]);
set(gca,'xticklabel',bits.')
grid on;

%Espectro Bifase Marca
N=300;
bits=randint(1,N)*2-1;
bfm=[];
marca=bits(1);
for n=1:N
    marca=-1*marca;
    if(bits(n)==1)
        bfm=[bfm s1*bits(n)*marca];
        marca=-1*marca;
    else
        bfm=[bfm s2*marca];
    end
end
BFM=fftshift(fft(bfm,100000))*ts;
f=linspace(-1/(2*ts),1/(2*ts),length(BFM));
subplot(2, 1, 2);
plot(f, abs(BFM));
title('Espectro');
axis([-5 5 -0.5 max(abs(BFM))]);
grid on;

%% Bifase Espacio
N=10;
s1=[-1*ones(1,50) ones(1,50)];
s2=ones(1,100);
%bits=[1 -1 -1 1 -1 -1 1 1 1 -1 -1 -1 1];
bits=randint(1,N)*2-1;
bfs=[];
marca=bits(1);
for n=1:N
    marca=-1*marca;
    if(bits(n)==-1)
        bfs=[bfs s1*bits(n)*marca];
        marca=-1*marca;
    else
        bfs=[bfs s2*marca];
    end
end
figure(8);
subplot(2, 1, 1);
plot(t, bfs);
title('Codigo Bifase Espacio');
axis([0, N -1.5 1.5]);
set(gca,'xticklabel',bits.')
grid on;

%Espectro Bifase Espacio
N=300;
bits=randint(1,N)*2-1;
bfs=[];
marca=bits(1);
for n=1:N
    marca=-1*marca;
    if(bits(n)==-1)
        bfs=[bfs s1*bits(n)*marca];
        marca=-1*marca;
    else
        bfs=[bfs s2*marca];
    end
end
BFS=fftshift(fft(bfs,100000))*ts;
f=linspace(-1/(2*ts),1/(2*ts),length(BFS));
subplot(2, 1, 2);
plot(f, abs(BFS));
title('Espectro');
axis([-5 5 -0.5 max(abs(BFS))]);
grid on;

%% Manchester Diferencial *
N=10;
s1=[zeros(1,50) ones(1,50)];
s0=[ones(1,50) zeros(1,50)];
%bits=[1 -1 -1 1 -1 -1 1 1 1 -1 -1 -1 1];
bits=randint(1,N)*2-1;
marca=bits(1);
md=[];
for n=1:N
    marca=-1*marca;
    if(marca==-1)
        if(bits(n)==1)
            md=[md s0];
        else
            md=[md s1];
        end
    else
        if(bits(n)==1)
            md=[md s1];
        else
            md=[md s0];
        end
        marca=-1*marca;
    end
end
figure(9);
subplot(2, 1, 1);
plot(t, md);
title('Codigo Manchester Diferencial');
axis([0, N -1.5 1.5]);
set(gca,'xticklabel',bits.')
grid on;

%Manchester Diferencial
N=300;
bits=randint(1,N)*2-1;
marca=bits(1);
md=[];
for n=1:N
    marca=-1*marca;
    if(marca==-1)
        if(bits(n)==1)
            md=[md s0];
        else
            md=[md s1];
        end
    else
        if(bits(n)==1)
            md=[md s1];
        else
            md=[md s0];
        end
        marca=-1*marca;
    end
end
MD=fftshift(fft(md,100000))*ts;
f=linspace(-1/(2*ts),1/(2*ts),length(MD));
subplot(2, 1, 2);
plot(f, abs(MD));
title('Espectro');
axis([-5 5 -0.5 max(abs(MD))]);
grid on;

%% Miller *verificar
N=10;
s1=[ones(1,50) -1*ones(1,50)];
s0=ones(1,100);
bits=randint(1,N)*2-1;
mi=[];

if(bits(1)==1)
    mi=[mi s1*bits(1)];
else
    mi=[mi s0];
end
for n=2:N
    if(bits(n)==1)
        if(bits(n-1)==1)
            if(mi((n-1)*100-1)==-1)
                 mi=[mi -1*s1];
            else
                mi=[mi s1];
            end
        else
            if(mi((n-1)*100-1)==-1)
                 mi=[mi 1*s1];
            else
                mi=[mi -1*s1];
            end
        end
        
    else
        mi=[mi s0*bits(n)];
    end
end
figure(10);
subplot(2, 1, 1);
plot(t, mi);
title('Codigo Miller');
axis([0, N -1.5 1.5]);
set(gca,'xticklabel',bits.')
grid on;

%Miller Diferencial
N=300;
bits=randint(1,N)*2-1;
if(bits(1)==1)
    mi=[mi s1*bits(1)];
else
    mi=[mi s0];
end
for n=2:N
    if(bits(n)==1)
        if(bits(n-1)==1)
            if(mi((n-1)*100-1)==-1)
                 mi=[mi -1*s1];
            else
                mi=[mi s1];
            end
        else
            if(mi((n-1)*100-1)==-1)
                 mi=[mi 1*s1];
            else
                mi=[mi -1*s1];
            end
        end
        
    else
        mi=[mi s0*bits(n)];
    end
end
MI=fftshift(fft(mi,100000))*ts;
f=linspace(-1/(2*ts),1/(2*ts),length(MI));
subplot(2, 1, 2);
plot(f, abs(MI));
title('Espectro');
axis([-5 5 -0.5 max(abs(MI))]);
grid on;

%% Machester
%s0=[zeros(1,50) ones(1,50)]
%s1=[ones(1,50) zeros(1,50)]
