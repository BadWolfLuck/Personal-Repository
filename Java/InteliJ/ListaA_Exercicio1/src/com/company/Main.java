package com.company;

import java.util.Scanner;
import javax.swing.*;

public class Main_exercicio1 {
    public static void main(String[]Args) {

        JOptionPane.showMessageDialog(null,"AAAAAAAAAAAAAAAAAAAAAAAAAa");
        double num1, num2, soma, sub, mult, divi;

        System.out.println("Digite o primeiro número:");
        Scanner sc1 = new Scanner(System.in);
        num1=(sc1.nextDouble());
        sc1.close();
        System.out.println("Digite o segundo número");
        Scanner sc2 = new Scanner(System.in);
        num2 = (sc2.nextDouble());
        sc2.close();

        soma = num1+num2;
        sub = num1-num1;
        mult =num1*num2;
        divi = num1/num2;

        System.out.println("Dado os dois números\n A soma é: "+ soma +"\n A subtração é: "+ sub +"\n A multiplicação é:"+ mult +"\n A divisão é:" + divi);
    }


}
