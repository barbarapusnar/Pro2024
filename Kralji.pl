resitev([]).
resitev([X/Y|Ostale]):-
    resitev(Ostale),
    member(Y,[1,2,3,4,5,6,7,8]),
    nenapada(X/Y,Ostale).
nenapada(_,[]).
nenapada(X/Y,[X1/Y1|Ostale]):-
             Y =\= Y1,
             Y1-Y =\= X1-X,
             Y1-Y =\= X-X1,
             nenapada(X/Y,Ostale).
predloga([1/Y1,2/Y2,3/Y3,4/Y4,5/Y5,6/Y6,7/Y7,8/Y8]).
