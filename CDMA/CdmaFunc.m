function [cdma] = CdmaFunc(x, secGold)
%Funcion para convertit a cdma
%   x: Secuancia condificacda
    y=x';
    z=y(:);
    cdma=z*secGold;
end

