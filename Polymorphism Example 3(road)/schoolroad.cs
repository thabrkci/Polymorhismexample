class Schoolroad:Stabilizethecarspeed{
    public override void stabilizeCar()
    {
        base.stabilizeCar();//Sürücümüze okul yolunda olduğu için hızını sabitlemesi gerektiği uyarısı yaptık.
        Console.WriteLine("Your location is on the way to school");//Sürücümüze lokasyonunun okul çevresinde olduğunu belirttik.
        base.stabilizeCarslow();//Sürücümüze yavaşlaması için tekrar,uyarı yaptık.
        Console.WriteLine("check left and right");//Sağını ve solunu kontrol edebilmesi adına uyarı yaptık.
    }
}