using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um iPhone
        Iphone meuIphone = new Iphone(
            numero: "9999-0000",
            modelo: "iPhone 14",
            imei: "123456789012345",
            memoria: 128
        );

        // Criando um Nokia
        Nokia meuNokia = new Nokia(
            numero: "8888-1111",
            modelo: "Nokia 3310",
            imei: "987654321098765",
            memoria: 32
        );

        // Testando métodos do iPhone
        Console.WriteLine("Smartphone iPhone");
        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("WhatsApp");

        // Testando métodos do Nokia
        Console.WriteLine("\nSmartphone Nokia");
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("Telegram");
    }
}
