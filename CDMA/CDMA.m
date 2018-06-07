clear all;
close all;
clc;

% y=SecGold();
% %normalizacion de la energia valor maximo
% s1=(y{1}*2-1)/sqrt(31);
% s2=(y{2}*2-1)/sqrt(31);
% s3=(y{3}*2-1)/sqrt(31);
% s4=(y{5}*2-1)/sqrt(31);
% s5=(y{8}*2-1)/sqrt(31);
% s6=(y{13}*2-1)/sqrt(31);
% 
% z=xcorr(s1,s2);
% z1=xcorr(s1,s1);
% plot(z);
% hold on;
% plot(z1,'r-');
% grid on;

%% {CDMA Codificacion}
% fs=8000;
% Tiempo de grabacion=1s
% Numero de muestras=8000
% 1 cabal monoaural
[x1,fs]=audioread('disturbence.wav');
x1=x1(:,1);
A1=max(abs(x1));
x1=x1/A1;
x1mu=lin2mu(x1);
x1mubin=de2bi(x1mu,8,'left-msb');

%% {CDMA Decodificacion}
dx1munbin=bi2de(x1mubin);
dx1mu=mu2lin(dx1munbin);
dx1=x1*A1;


