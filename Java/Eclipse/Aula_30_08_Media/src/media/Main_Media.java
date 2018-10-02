//Clacular a média de dois valores inseridos pelo usuário.
package media;

import javax.swing.JOptionPane;
import java.util.*;

@SuppressWarnings("unused")
public class Main_Media {
	public static void main(String[]args) {
		Double num1, num2, media;
		
		num1 = Double.parseDouble(JOptionPane.showInputDialog("Digite o primeiro número: "));
		num2 = Double.parseDouble(JOptionPane.showInputDialog("Digite o segundo número: "));
		
		media = (num1 + num2) / 2;
		
		JOptionPane.showMessageDialog(null, "A média é: "+ media,null, JOptionPane.PLAIN_MESSAGE);
		System.exit(0);
	}

}
