using System;

class MainClass {
  public static void Main (string[] args) {
    /*
    5 -Um motorista deseja colocar no seu tanque X reais de gasolina.
    Escreva um programa para ler o preço do litro
    da gasolina e o valor do pagamento, e exibir
    quantos litros o motorista conseguiu colocar no tanque.
    */

    Console.WriteLine ("Digite o preço do litro de Gasolina");
    float precoLitro = float.Parse(Console.ReadLine());

    Console.WriteLine ("Qual o valor do pagamento?");
    float valorPago = float.Parse(Console.ReadLine());

    float litros = valorPago / precoLitro;

    Console.WriteLine ($"Você abasteceu com {litros} litros de gasolina.");
  }
}