//Soma de dois numeros digitados pelo usuário.
package pacote_aula_23_08;

import java.util.Scanner;
import javax.swing.JOptionPane;


@SuppressWarnings("unused")
public class Main {
	
	public static void main(String[] args) {
		int num1, num2, soma;
		Soma s1 = new Soma();
		int option = JOptionPane.showConfirmDialog(null,"Vamos Somar?", "Bom Dia", JOptionPane.YES_NO_OPTION);
		if (option == 0) {
			num1 = Integer.parseInt(JOptionPane.showInputDialog("Escreva o primeiro número: "));
			num2 = Integer.parseInt(JOptionPane.showInputDialog("Escreva o Segundo número: "));
			
			soma = s1.soma(num1, num2);
		    JOptionPane.showMessageDialog(null,"O resultado é: " + soma);
		}
		else {
			System.exit(0);
		}

		
	}

}
