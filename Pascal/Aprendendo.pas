//program soma_dois_numeros;
 
//var
  // numero1, numero2, resultado : integer;
 
//begin
  // write('Digite o primeiro n�mero: ');
   //readln(numero1);
   //write('Digite o segundo n�mero: ');
   //readln(numero2);
   //resultado := numero1 + numero2;
   //write('O resultado da soma � ', resultado);
//end.
program calculo_idade;
const
 ano_atual = 2018;
var
ano, idade : integer;
nome : string;
begin
 write('Qual o seu nome? 
 ');
 readln(nome);
 write('Qual o ano do seu nascimento? 
 ');
 readln(ano);
 idade := ano_atual - ano;
 write('Prazer em te conhecer ',nome,' poxa voc� j� tem ',idade,' anos, ta ficando velho em.');
 end.
 




