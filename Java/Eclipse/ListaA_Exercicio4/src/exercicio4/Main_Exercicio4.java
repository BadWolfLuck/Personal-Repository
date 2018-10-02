package exercicio4;

import javax.swing.JOptionPane;
public class Main_Exercicio4 {
	public static void main(String[]Args) {
		double mm, pol;
		
		mm = Double.parseDouble(JOptionPane.showInputDialog(null,"Digite o valor em milimetros."));
		pol = mm/24.5;
		JOptionPane.showMessageDialog(null, "O valor em polegadas é de: "+ pol);
		
		
	}
}
