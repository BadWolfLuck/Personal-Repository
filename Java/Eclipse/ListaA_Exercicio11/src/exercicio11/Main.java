//Converter Real em Dólar;
package exercicio11;

import javax.swing.*;
public class Main {

	@SuppressWarnings("unused")
	public static void main(String[] args) {
		double dolar, real, cot;
		
		cot = Double.parseDouble(JOptionPane.showInputDialog(null,"Qual a cotação do Dólar em relação ao Real?","Cotação do Dólar",3));
		
		real = Double.parseDouble(JOptionPane.showInputDialog(null,"Quantos Reais você quer converter?","Valor em Reais.",3));
		
		dolar = (real/cot);
		
		JOptionPane.showMessageDialog(null, "Após a conversão você tem: $"+dolar, "Resultado", 1);
	}

}
