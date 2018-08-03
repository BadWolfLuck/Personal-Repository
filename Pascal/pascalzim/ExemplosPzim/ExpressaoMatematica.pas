// -------------------------------------------------------------
// Programa que recebe o valor x, e calcula o valor y a partir 
// da seguinte expressão:
//
// Y = X + 2X + 3X + 4X + 5X ... 20X.
//
// Desenvolvido pelo beta-tester Danilo Rafael Galetti :~
// -------------------------------------------------------------

Program Pzim ;
var
 x,y,i,n: integer;
 
Begin
  // Solicita o valor de x
  write ('Digite um valor : ');
  read (x);
  
  //  Calcula o valor de y
  y:=0;
  For i:= 1 to 20 do
  Begin
 	y:=(x*I)+y;
  End ;	
 	
  // Imprime o resultado	
  writeln ('O resultado é ',y);  
End.
