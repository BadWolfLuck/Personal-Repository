//Converter Real em D�lar;
package exercicio11;

import javax.swing.*;
public class Main {

	@SuppressWarnings("unused")
	public static void main(String[] args) {
		double dolar, real, cot;
		
		cot = Double.parseDouble(JOptionPane.showInputDialog(null,"Qual a cota��o do D�lar em rela��o ao Real?","Cota��o do D�lar",3));
		
		real = Double.parseDouble(JOptionPane.showInputDialog(null,"Quantos Reais voc� quer converter?","Valor em Reais.",3));
		
		dolar = (real/cot);
		
		JOptionPane.showMessageDialog(null, "Ap�s a convers�o voc� tem: $"+dolar, "Resultado", 1);
	}

}
