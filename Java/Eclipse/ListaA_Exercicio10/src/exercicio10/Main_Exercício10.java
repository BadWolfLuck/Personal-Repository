//Calcular area e a circunfer�ncia do c�rculo dado o raio;
package exercicio10;

import javax.swing.JOptionPane;

public class Main_Exerc�cio10 {

	public static void main(String[] args) {
		double raio, area, comprimento;
		
		raio = Double.parseDouble(JOptionPane.showInputDialog(null,"Digite o raio do c�rculo"));
		
		area = 3.14 * (raio*raio);
		comprimento = 2 * 3.14 * raio;
		
		JOptionPane.showMessageDialog(null,"A �rea do c�rculo � de: "+area+"cm" + "\n"+"A circunfer�ncia do c�rculo � de: "+comprimento+"cm", "Resultado", 1);
	}
}
