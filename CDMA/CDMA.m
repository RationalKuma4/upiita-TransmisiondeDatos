clear all;
close all;
clc;

% Archivos
nombreArchivo0='smackyou.wav';
nombreArchivo1='smackyou.wav';
nombreArchivo2='smackyou.wav';
nombreArchivo3='smackyou.wav';
nombreArchivo4='smackyou.wav';
nombreArchivo5='smackyou.wav';

% Obtencion de secuencia gold
y=SecGold();
%normalizacion de la energia valor maximo
s0=(y{1}*2-1)/sqrt(31);
s1=(y{2}*2-1)/sqrt(31);
s2=(y{3}*2-1)/sqrt(31);
s3=(y{5}*2-1)/sqrt(31);
s4=(y{8}*2-1)/sqrt(31);
s5=(y{13}*2-1)/sqrt(31);

% Graficas de coreelacion
% z=xcorr(s1,s2);
% z1=xcorr(s1,s1);
% plot(z);
% hold on;
% plot(z1,'r-');
% grid on;

%% Codificacion lineal - ley mu
[fs,x,A]=CodificacionMuBi(nombreArchivo0);

%% CDMA


%% Decodificacion leymu - lineal
[dx]=DecodificacionMuBi(x, A);

% Prueba de sonido
sound(dx,fs)

