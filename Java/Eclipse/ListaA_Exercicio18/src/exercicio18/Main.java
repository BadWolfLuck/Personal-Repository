package exercicio18;

import javax.swing.JOptionPane;

public class Main {

	public static void main(String[] args) {
		double x1,x2,y1,y2,distancia,i,z;
		
		JOptionPane.showMessageDialog(null,"Digite os valores do primeiro ponto");
		x1 = Double.parseDouble(JOptionPane.showInputDialog(null,"Digite o eixo X: "));
		y1 = Double.parseDouble(JOptionPane.showInputDialog(null,"Digite o eixo Y: "));
		
		JOptionPane.showMessageDialog(null,"Digite os valores do segundo ponto");
		x2 = Double.parseDouble(JOptionPane.showInputDialog(null,"Digite o eixo X: "));
		y2 = Double.parseDouble(JOptionPane.showInputDialog(null,"Digite o eixo Y: "));
		
		i = x2-x1;
		z = y2-y1;
		distancia = Math.sqrt((i*i)+(z*z));
		
		JOptionPane.showMessageDialog(null, "A distância entre os dois pontos é de: "+distancia+"cm");

	}

}
