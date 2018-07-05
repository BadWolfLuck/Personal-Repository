import java.awt.Component;

import javax.swing.JOptionPane;

public class Main {

	private static final Component A = null;

	public static void main(String[] args) {
		int a;
		 a = Integer.parseInt(JOptionPane.showInputDialog("Quantas pessoas você quer cadastrar?"));
		 
		Pessoa[] p1 = new Pessoa[a];
		for(int i = 0; i<a; i++) {
			p1[i] = new Pessoa();
		}
		p1[2].Set_Nome("Batata");
		System.out.println(p1[2].Get_Nome());
		
		/*String nome;
		
		nome = JOptionPane.showInputDialog("Digite seu nome: ");
		System.out.println("" + nome);
		*/
	}

}
