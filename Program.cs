using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//R:    Instanciar um objeto Nokia e um objeto Iphone com dados fictícios
//      Chamar os métodos Ligar(), ReceberLigacao() e InstalarAplicativo
//      Imprimir as informações dos objetos no console
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Testando Nokia ===");
        Nokia nokia = new Nokia("1234-5678", "Nokia 3310", "111111111", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n=== Testando iPhone ===");
        Iphone iphone = new Iphone("9876-5432", "iPhone 15", "222222222", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine("\n=== Testes concluídos ===");
    }
}