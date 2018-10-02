// Exibir a media da temperatura de um semana.
package exercicio2;

import java.util.Scanner;

public class Main_Exercicio2 {

	public static void main(String[] args) {
		double temp, seg,ter,qua,quin,sex,sab,dom ,media = 0;
		
		Scanner sc1 = new Scanner(System.in);
		System.out.println("Qual a temperatura de Segunda-Feira?");
		temp = sc1.nextDouble();
		seg = temp;
		
		System.out.println("Qual a temperatura de Terça-Feira?");
		temp = sc1.nextDouble();
		ter = temp;
		
		System.out.println("Qual a temperatura de Quarta-Feira?");
		temp = sc1.nextDouble();
		qua = temp;
		
		System.out.println("Qual a temperatura de Quinta-Feira?");
		temp = sc1.nextDouble();
		quin = temp;
		
		System.out.println("Qual a temperatuta de Quinta-Feira?");
		temp = sc1.nextDouble();
		sex = temp;
		
		System.out.println("Qual a temperatura de Sexta-Feira?");
		temp = sc1.nextDouble();
		sab = temp;
		
		System.out.println("Qual a temperatura de Sábado?");
		temp = sc1.nextDouble();
		sab = temp;
		
		System.out.println("Qual a temperatura de Domingo?");
		temp = sc1.nextDouble();
		dom = temp;
		
		sc1.close();
		
		media = (seg+ter+qua+quin+sex+sab+dom)/7;
		
		System.out.println("A temperatura média da semana é de: " + media + "°C");
	}

}
