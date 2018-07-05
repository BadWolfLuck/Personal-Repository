
public class Endereco {

	public Endereco() {
		// TODO Auto-generated constructor stub
	}
	private String bairro, rua;
	private int cep, num;
	
	public String Get_Bairro(){
		return bairro;
	}
	public void Set_Bairro(String xBairro) {
		bairro = xBairro;
	}
	
	public String Get_Rua() {
		return rua;
	}
	public void Set_Rua(String xRua) {
		rua = xRua;
	}
	
	public int Get_Cep() {
		return cep;
	}
	public void Set_Cep(int xCEP) {
		cep = xCEP;
	}
	
	public int Get_Numero() {
		return num;
	}
	public void Set_Numero(int xNum) {
		num = xNum;
	}

}
