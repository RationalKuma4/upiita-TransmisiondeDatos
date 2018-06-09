function [fs, xmubin, A] = CodificacionMuBi(audioFile)
%Codififcacion de archivo de audio
%   audioFile: Nombre de archivo
%   fs: frecuencia de muestreo
%   xmubin: matriz codificada
    [x,fs]=audioread(audioFile);
    x=x(:,1);
    A=max(abs(x));
    x=x/A;
    xmu=lin2mu(x);
    xmubin=de2bi(xmu,8,'left-msb')*2-1;
end

