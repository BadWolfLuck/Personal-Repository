//Calcular média entre duas notas e exibir se o aluno foi aprovado ou não;
package aula_06_09;

import javax.swing.JOptionPane;

public class main_aula_06_09 {
	public static void main(String[]args) {
		double num1, num2, media;
		//Gambiarra para entrar na condi��o...
		//num1 = num2 = media =-1;
		//Comdi��o para impedir de entrar numeros menores que 0 e maiores que 10
		do {
		num1 = Double.parseDouble(JOptionPane.showInputDialog(null,"Insira a nota NP1:"));
		if(num1<0 || num1>10) {
			JOptionPane.showMessageDialog(null,"Digite um número entre 0 e 10.");
		}
		}while(num1<0 || num1>10);
		do {
		num2 = Double.parseDouble(JOptionPane.showInputDialog(null,"Insira a nota NP2"));
		if(num2<0||num2>10) {
			JOptionPane.showMessageDialog(null,"Digite um n�mero entre 0 e 10.");
		}
		}while(num2<0 || num2>10);
		//Calculo da m�dia
		media = (num1+num2)/2;
		//Exibir se foi aprovado ou n�o.
		if(media>=6) {
			JOptionPane.showMessageDialog(null,"Aprovado\nParab�ns");
		}
		else {
			JOptionPane.showMessageDialog(null,"Reprovado\nEstude mais");
		}
	}
}