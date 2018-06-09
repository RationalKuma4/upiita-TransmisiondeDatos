function [dx] = DecodificacionMuBi(xmubin, A)
%Decodificador
%   xmubin: matriz codificada
%   dx: matriz lineal
    nvector=(xmubin+1)/2;
    dxmunbin=bi2de(nvector,'left-msb');
    dxmu=mu2lin(dxmunbin);
    dx=dxmu*A;
end

