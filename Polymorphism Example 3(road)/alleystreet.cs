class Alleystreet:Stabilizethecarspeed{
    public override void stabilizeCar()
    {
        base.stabilizeCar();//Sürücümüz ara sokakta olduğu için hızını sabitlemesi gerektiğine dair uyarımızı yaptık.
        base.stabilizeCarslow();//Sürücümüze yavaşlaması gerektiği için uyarı yaptık.
        System.Console.WriteLine("Please İn The Alley, keep your speed at 50.");//Akabinde sürücünün ara sokakta olduğunu ve hızını 50/km'ye sabitlemesi gerektiğini belirttik.

    }

    




}