namespace Polymorphism_ve_Sealed_Class;

using System;

// Temel sınıf (base class)
class Sekil
{
    public virtual void Ciz()
    {
        Console.WriteLine("Bir şekil çiziliyor");
    }
}

//Türetilmiş Sınıf
class Dikdortgen : Sekil//Dikdörtgen isimli class Şekil sınıfından kalıtım almakta.
{
    public override void Ciz()
    
    {
        Console.WriteLine("Dikdörtgen çiziliyor");
    }
}

// Başka bir türetilmiş sınıf (derived class)
class Daire : Sekil
{
    public override void Ciz()
    {
        Console.WriteLine("Daire çiziliyor");
    }
}

class Program
{
    static void Main()
    {
        // Polymorphism örneği
        Sekil sekil1 = new Dikdortgen();
        Sekil sekil2 = new Daire();

        // Her iki durumda da Ciz metodu farklı şekilde çalışır
        sekil1.Ciz(); // "Dikdörtgen çiziliyor"
        sekil2.Ciz(); // "Daire çiziliyor"
    }
}