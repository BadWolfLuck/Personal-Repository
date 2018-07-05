public class PartDois {

	public String nome;
	public Double cpf;
	public String email;
	
	public String getNome() {
			return nome;
		}
	
	public void setNome(String nome) {
		this.nome = nome;
	}
	
	public Double getCpf() {
		return cpf;
	}

	public void setCpf(Double cpf) {
		this.cpf = cpf;
	}
	
	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public void Status() {
		System.out.println(""+this.nome);
		
	}
}
