//Somar dois numeros interios usando JOptionPane. Fiz isso aula passada por curiosidade.
package aula_30_08;
import java.util.*;
import javax.swing.JOptionPane;

@SuppressWarnings("unused")
public class Main_30_08 {
	public static void main(String[]args) {
		int num1, num2, soma;
		
		num1 = Integer.parseInt(JOptionPane.showInputDialog("Digite o primeiro N�mero inteiro: "));
		num2 = Integer.parseInt(JOptionPane.showInputDialog("Digite o segundo N�mero inteiro: "));
		
		soma = num1 + num2;
	    JOptionPane.showMessageDialog(null, "A soma � "+soma,"Resultado da Soma: ", JOptionPane.PLAIN_MESSAGE,null);
		System.exit(0);
	}
}
