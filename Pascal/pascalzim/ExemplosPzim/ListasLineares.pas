// -------------------------------------------------------------
// Este programa mostra mostra como construir listas lineares
// usando ponteiros. :~
// -------------------------------------------------------------

Program ExemploPzim ;

// Tipo de dados que representa um n� da lista
type TNo = record
              dado : integer ;  // Dado armazenado no n�
              prox : ^TNo ; // Ponteiro para pr�ximo n�
           end ;

Var pinicio: ^TNo;    // Guarda endere�o do 1� n� da lista
    p1: ^TNo;         // Auxiliar. Guarda endere�o de um n�
    resposta : char ; // Auxiliar. Controla repeti��o.
    
Begin
  pinicio := nil ;
  
  // Repeti��o que monta a lista, adicionando novos n�s
  repeat
     new( p1 );
     write( 'Entre com novo inteiro: ' );
     readln( p1^.dado ) ;
     p1^.prox := pinicio ;
     pinicio := p1 ;
     write( 'Novo dado(S/N)?' );
     readln( resposta );
     resposta := upcase( resposta );
  Until resposta = 'N' ;

  // Percorre a lista, imprimindo seus elementos
  p1 := pinicio ;
  while( p1 <> nil ) do
   Begin
      writeln( 'Achei: ' , p1^.dado );
      p1 := p1^.prox ;
   End;

  // Percorre a lista, liberando mem�ria alocada para os n�s
  while( pinicio <> nil ) do
    Begin
       p1 := pinicio ;
       pinicio := pinicio^.prox ;
       dispose( p1 );
    End;

  readln ;
End.
