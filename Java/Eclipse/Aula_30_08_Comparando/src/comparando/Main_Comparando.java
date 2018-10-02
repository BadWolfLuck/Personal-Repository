package comparando;

import javax.swing.JOptionPane;

public class Main_Comparando {
	public static void main(String[] args) {
		int num1 = 0,num2 = 0;
		String resultado = null;
		
		num1 = Integer.parseInt(JOptionPane.showInputDialog("Digite primeiro número inteiro:"));
		num2 = Integer.parseInt(JOptionPane.showInputDialog("Digite o segundo número inteiro:"));
		
		if(num1 == num2) {
			resultado = num1 +" = "+ num2;
		}
		if(num1 != num2){
			resultado = num1+" != "+num2 ;
		}
		if(num1 > num2) {
			resultado = resultado + "\n" + num1 + " > " + num2 ;
		}
		if(num1 < num2) {
			resultado = resultado + "\n"+ num1 +" < " + num2;
		}
		if(num1 <= num2) {
			resultado = resultado + "\n" + num1 + " <= " + num2;
		}
		if(num1>= num2) {
			resultado = resultado + "\n" + num1 + " >= "+ num2;
		}
		JOptionPane.showMessageDialog(null,resultado, "Resultados da comparação",JOptionPane.INFORMATION_MESSAGE);
		System.exit(0);
	}

}
