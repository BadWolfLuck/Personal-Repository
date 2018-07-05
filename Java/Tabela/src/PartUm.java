import java.awt.Dialog;
import java.util.Scanner;
import javax.swing.JOptionPane;



public class PartUm {	
	

	public String nome;
	public Double cpf;
	
	

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
			
	
	int op;
	
	do{
		
		
		String nome = JOptionPane.showInputDialog("Insira o seu nome: ");
		String cpf = JOptionPane.showInputDialog("Digite seu cpf: ");
		
		JOptionPane.showConfirmDialog(null,"Esse é seu nome "+ nome);
		JOptionPane.showConfirmDialog(null,"Esse é seu cpf  "+ cpf);
		
		
	
		 op= Integer.parseInt(JOptionPane.showInputDialog("Deseja continuar? Digite 0 para sair "));
		 
	}while(op != 0);
	
	}
}