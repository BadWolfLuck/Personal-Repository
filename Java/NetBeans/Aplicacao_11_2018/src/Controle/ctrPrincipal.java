package Controle;

public class ctrPrincipal {
   
    public String Somar(String a, String b){
        Double num1,num2;
        String res;
        num1 = Double.parseDouble(a);
        num2 = Double.parseDouble(b);
        Double resultado = num1 + num2;
        res = Double.toString(resultado);
        return res;
    }
    
}
