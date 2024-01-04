class mainRoad:Stabilizethecarspeed{
    public override void stabilizeCar()
    {
        //base.stabIlIzecar();--->Yorum satırı içine aldık çünkü,sürücü ana yolda olduğu için yavaşlaması gerekmiyor ve normal hızında seyredebilir.
        Console.WriteLine("You don't need to slow down, you can keep going at this speed.");
        base.stabilizeCar();
    }
}