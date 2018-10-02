//Conversão de temperatura C para F;
package exercicio3;

import javax.swing.JOptionPane;

public class Main_Exercicio3 {
	public static void main(String[] args) {
		double far, cel;
		
		cel = Double.parseDouble(JOptionPane.showInputDialog(null,"Digite o uma temperatura em Celsius"));
		far = (1.8 * cel) + 32;
		JOptionPane.showMessageDialog(null,"A temperatura em Farenheit é de: "+far+"°F");
	}

}
