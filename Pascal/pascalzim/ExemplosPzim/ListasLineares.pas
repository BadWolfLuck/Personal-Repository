// -------------------------------------------------------------
// Este programa mostra mostra como construir listas lineares
// usando ponteiros. :~
// -------------------------------------------------------------

Program ExemploPzim ;

// Tipo de dados que representa um nó da lista
type TNo = record
              dado : integer ;  // Dado armazenado no nó
              prox : ^TNo ; // Ponteiro para próximo nó
           end ;

Var pinicio: ^TNo;    // Guarda endereço do 1º nó da lista
    p1: ^TNo;         // Auxiliar. Guarda endereço de um nó
    resposta : char ; // Auxiliar. Controla repetição.
    
Begin
  pinicio := nil ;
  
  // Repetição que monta a lista, adicionando novos nós
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

  // Percorre a lista, liberando memória alocada para os nós
  while( pinicio <> nil ) do
    Begin
       p1 := pinicio ;
       pinicio := pinicio^.prox ;
       dispose( p1 );
    End;

  readln ;
End.
