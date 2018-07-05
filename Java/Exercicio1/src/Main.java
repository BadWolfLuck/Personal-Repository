import java.util.Scanner;

public class Main {

	@SuppressWarnings({ "resource", "unused" })
	public static void main(String[] args) {
		Nome n1 = new Nome();
		Nome n2 = new Nome();
		Nome n3 = new Nome();
		
		System.out.println("Digite o nome da pessoa 1:");
		Scanner nome1 = new Scanner(System.in);
		n1.SetNome(nome1.next());
		
		System.out.println("Digite a idade da pessoa 1");
		Scanner idade1 = new Scanner(System.in);
		n1.i1.SetIdade(idade1.nextInt());
		
		System.out.println("Digite o nome da pessoa 2:");
		Scanner nome2 = new Scanner(System.in);
		n2.SetNome(nome2.next());
		
		System.out.println("Digite a idade da pessoa 2:");
		Scanner idade2 = new Scanner(System.in);
		n2.i1.SetIdade(idade2.nextInt());
		
		System.out.println("Digite o nome da pessoa 3:");
		Scanner nome3 = new Scanner(System.in);
		n3.SetNome(nome3.next());
		
		System.out.println("Digite a idade da pessoa 3:");
		Scanner idade3 = new Scanner(System.in);
		n3.i1.SetIdade(idade3.nextInt());
		
		int a = n1.i1.GetIdade();
		int b = n2.i1.GetIdade();
		int c = n3.i1.GetIdade();
		
		int maior,menor;
		
		if(a>b && a>c) {
			maior = a;
			System.out.println("A pessoa mais velha é: " + n1.GetNome());
		}
		else if(b>a && b>c) {
			maior = b;
			System.out.println("A pessoa mais velha é: " + n2.GetNome());
		}
		else{
			maior = c;
			System.out.println("A pessoa mais velha é: " + n3.GetNome());
		}
		
		if(maior == a && c>b) {
			menor = b;
			System.out.println("A pessoa mais nova é: " + n2.GetNome());
		}
		else if(maior == a && b>c) {
			menor = c;
			System.out.println("A pessoa mais nova é: " + n3.GetNome());
		}
		else if(maior == b && c>a) {
			menor = a;
			System.out.println("A pessoa mais nova é: " + n1.GetNome());
		}
		else if(maior == b && a>c) {
			
		}
		else if(maior == c && c>b) {
			menor = b;
			System.out.println("A pessoa mais nova é: " + n2.GetNome());
		}
		else if(maior == c && b>c) {
		menor = c;
		System.out.println("A pessoa mais nova é: " + n3.GetNome());
		}
	}

}
