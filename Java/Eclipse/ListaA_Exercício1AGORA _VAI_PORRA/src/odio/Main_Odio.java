package odio;

import java.util.Scanner;

public class Main_Odio {

	public static void main(String[] args) {
		double num1, num2, soma, sub, mult, divi;

        System.out.println("Digite o primeiro n�mero:");
        Scanner sc1 = new Scanner(System.in);
        num1=(sc1.nextDouble());
        System.out.println("Digite o segundo n�mero");
        num2=(sc1.nextDouble());
        sc1.close();
        
        soma = num1+num2; 
        sub = num1-num2;
        mult =num1*num2;
        divi = num1/num2;
        
        System.out.println("Dado os dois n�meros\n A soma �: "+ soma +"\n A subtra��o �: "+ sub +"\n A multiplica��o �:"+ mult +"\n A divis�o �:" + divi);
	

	}

}
