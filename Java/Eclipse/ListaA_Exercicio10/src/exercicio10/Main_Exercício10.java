//Calcular area e a circunferência do círculo dado o raio;
package exercicio10;

import javax.swing.JOptionPane;

public class Main_Exercício10 {

	public static void main(String[] args) {
		double raio, area, comprimento;
		
		raio = Double.parseDouble(JOptionPane.showInputDialog(null,"Digite o raio do círculo"));
		
		area = 3.14 * (raio*raio);
		comprimento = 2 * 3.14 * raio;
		
		JOptionPane.showMessageDialog(null,"A área do círculo é de: "+area+"cm" + "\n"+"A circunferência do círculo é de: "+comprimento+"cm", "Resultado", 1);
	}
}
