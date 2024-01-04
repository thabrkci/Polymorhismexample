namespace Polymorphism_Example_3_road_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stabilize the car speed !");
        Console.WriteLine("/*/*/*/*/AlleyStreet/*/*/*/*/*/*");
        Alleystreet alleystreet = new Alleystreet();
        alleystreet.stabilizeCar();
        alleystreet.stabilizeCarslow();
        //Ara sokakta yavaşlamasını ve hız sınırı 50 ye sabitlemesi için sürücüye uyarı verdik:
        Console.WriteLine("/*/*/*/*/Maın Road/*/*/*/*/*/");
        mainRoad maınroad = new mainRoad();
        maınroad.stabilizeCar();
        //Sürücü ana yolda olduğu için metodu biçimlendirdik(değiştirdik) ve yavaşlamamasını 100 ile gittiği için normal hızda olduğu için dikkatli olması gerektiğini belirttik.
        Console.WriteLine("/*/*/*/*/*/School Road/*/*/*/*/*/");
        Schoolroad schoolroad = new Schoolroad();
        schoolroad.stabilizeCar();
        schoolroad.stabilizeCarslow();
        /*Sürücü okul yolunda olduğu için stabılıze car sınıfından kalıtım alarak yavaşlamasını gerektiğini söyledik ve
        daha sonrasında okul yolunda olduğunu ve sağını solunu kontrol etmesi gerektiğini belirttik aynı şekilde metodumuza eklemeler yaptık biçimlendirdik.*/

    }
}
