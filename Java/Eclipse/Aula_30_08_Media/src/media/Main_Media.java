//Clacular a m�dia de dois valores inseridos pelo usu�rio.
package media;

import javax.swing.JOptionPane;
import java.util.*;

@SuppressWarnings("unused")
public class Main_Media {
	public static void main(String[]args) {
		Double num1, num2, media;
		
		num1 = Double.parseDouble(JOptionPane.showInputDialog("Digite o primeiro n�mero: "));
		num2 = Double.parseDouble(JOptionPane.showInputDialog("Digite o segundo n�mero: "));
		
		media = (num1 + num2) / 2;
		
		JOptionPane.showMessageDialog(null, "A m�dia �: "+ media,null, JOptionPane.PLAIN_MESSAGE);
		System.exit(0);
	}

}
