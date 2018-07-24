//program soma_dois_numeros;
 
//var
  // numero1, numero2, resultado : integer;
 
//begin
  // write('Digite o primeiro número: ');
   //readln(numero1);
   //write('Digite o segundo número: ');
   //readln(numero2);
   //resultado := numero1 + numero2;
   //write('O resultado da soma é ', resultado);
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
 write('Prazer em te conhecer ',nome,' poxa você já tem ',idade,' anos, ta ficando velho em.');
 end.
 




