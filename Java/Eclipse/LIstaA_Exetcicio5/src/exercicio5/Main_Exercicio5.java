//Exibir o valor da compra
package exercicio5;

import javax.swing.*;

public class Main_Exercicio5 {

	public static void main(String[] args) {
		double ham,batata,refri,ceva,doce,total=0,i;
		ham = 8;
		batata = 12;
		refri = 3;
		ceva = 5;
		doce = 3;
		
		i = Double.parseDouble(JOptionPane.showInputDialog(null,"Quantos Hamburgueres voc� comprou?"));
		total = total + (i*ham);
		i = Double.parseDouble(JOptionPane.showInputDialog(null,"Quantas Batatas voc� comprou?"));
		total = total + (i*batata);
		i = Double.parseDouble(JOptionPane.showInputDialog(null,"Quantos Refrigerantes voc� comprou?"));
		total = total + (i*refri);
		i = Double.parseDouble(JOptionPane.showInputDialog(null,"Quantas Cervejas voc� comprou?"));
		total = total + (i*ceva);
		i = Double.parseDouble(JOptionPane.showInputDialog(null,"Quantos doces voc� comprou?"));
		total = total + (i*doce);
		
		JOptionPane.showMessageDialog(null,"O valor total da compra � de: R$"+total);
	}

}
