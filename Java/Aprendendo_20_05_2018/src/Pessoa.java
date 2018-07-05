
public class Pessoa {

	public Pessoa() {
		Endereco end = new Endereco();
	}
	
	private String nome;
	private double salario;
	private int cpf;
	
	public String Get_Nome(){
		return nome;
	}
	public void Set_Nome(String xNome) {
		nome = xNome;
		
	}
	public double Get_Salario() {
		return salario;
	}
	public void Set_Salario(double xSalario) {
		salario = xSalario;
		
	}
	public int Get_CPF() {
		return cpf;
	}
	public void Set_CPF(int xCPF) {
		cpf = xCPF;
	}

}
