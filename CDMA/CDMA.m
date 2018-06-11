clear all;
close all;
clc;

% Archivos
nombreArchivo0='rec0.wav';
nombreArchivo1='rec1.wav';
nombreArchivo2='rec2.wav';
nombreArchivo3='rec3.wav';
nombreArchivo4='rec4.wav';
nombreArchivo5='rec5.wav';

% Obtencion de secuencia gold
y=SecGold();
%normalizacion de la energia valor maximo
s0=(y{1}*2-1)/sqrt(31);
s1=(y{2}*2-1)/sqrt(31);
s2=(y{3}*2-1)/sqrt(31);
s3=(y{5}*2-1)/sqrt(31);
s4=(y{8}*2-1)/sqrt(31);
s5=(y{13}*2-1)/sqrt(31);

%% Transmisor
% Codificacion lineal - ley mu
[fs,x0,A]=CodificacionMuBi(nombreArchivo0);
[fs,x1,A]=CodificacionMuBi(nombreArchivo1);
[fs,x2,A]=CodificacionMuBi(nombreArchivo2);
[fs,x3,A]=CodificacionMuBi(nombreArchivo3);
[fs,x4,A]=CodificacionMuBi(nombreArchivo4);
[fs,x5,A]=CodificacionMuBi(nombreArchivo5);

% CDMA para todos los archivos de audio
cdma0=CdmaFunc(x0,s0);
cdma1=CdmaFunc(x1,s1);
cdma2=CdmaFunc(x2,s2);
cdma3=CdmaFunc(x3,s3);
cdma4=CdmaFunc(x4,s4);
cdma5=CdmaFunc(x5,s5);

% Matriz total cdma
cdma=cdma0+cdma1+cdma2+cdma3+cdma4+cdma5;

% Creamos archivo
cdmaT=cdma';
fid=fopen('cdma.txt','wt');
fprintf(fid,'%6.4f\n',cdmaT);
fclose(fid);

%% Receptor
y=load('cdma.txt');
cdmarec=vec2mat(y,31);

% Recuperamos informacion de interes
% Variamo s dependiendo la informacion que queremos recuperar
usuario0=cdmarec*s0';
recvover=sign(usuario0);    % Detector

% Contruimos matriz de vuelta
recMat=vec2mat(recvover,8);

% Decodificacion leymu - lineal
[dx]=DecodificacionMuBi(recMat, A);

% Prueba de sonido
sound(dx,fs)

