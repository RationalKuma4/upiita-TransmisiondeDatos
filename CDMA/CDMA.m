clear all;
close all;
clc;

z=[1 2 3; 4 5 6; 7 8 9];
y=z';
w=y(:);
 
%% Archivos
nombreArchivo0='rec.wav';
% nombreArchivo1='smackyou.wav';
% nombreArchivo2='smackyou.wav';
% nombreArchivo3='smackyou.wav';
% nombreArchivo4='smackyou.wav';
% nombreArchivo5='smackyou.wav';

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
xt0=x(:)*s0;
xt1=x(:)*s1;
xt2=x(:)*s2;
xt3=x(:)*s2;
xt4=x(:)*s4;
xt5=x(:)*s5;

% Sumar las 6 matrices pasadas por la matriz acomodad y la secgold
% Matriz total cdma
cdma=xt0+xt1+xt2+xt3+xt4+xt5;

cdmaT=cdma';
fid=fopen('cdma.txt','wt');
fprintf(fid,'%6.4f\n',cdmaT);
fclose(fid);

y=load('cdma.txt');
cdmarec=vec2mat(y,31);

usuario0=cdmarec*s0';
recvover=sign(usuario0);

%% Decodificacion leymu - lineal
[dx]=DecodificacionMuBi(x, A);

% Prueba de sonido
sound(dx,fs)

