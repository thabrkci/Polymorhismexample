namespace Polymorphism_Example_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO EXERCİSES 2!");
        bodybuıld body = new bodybuıld();
        body.lIfttheweIght();
        Chest chest = new Chest();
        chest.lIfttheweIght();
        Shoulder shoulder = new Shoulder();
        shoulder.lIfttheweIght();

        
    }

}

class bodybuıld
{
  public virtual void lIfttheweIght()
  {
    Console.WriteLine("Lift the weight");
  }



}

class Chest:bodybuıld
{
    public override void lIfttheweIght()/*Bodybuild sınıfından lIfttheweIght(metodunu)kalıtım alarak
    Polymorphism uyguladık kaldır metodunu değiştirerek göğüs kası ile kaldır göğüs kası için yaptık*/
     
    {
        //base.lIfttheweIght();
        Console.WriteLine("Lift the weight with chest for chest");
    }
}

class Shoulder:bodybuıld/*Göğüs kası için olan örneği burada omuz kası için  gerçekleştirdik aynı şekilde 
kalıtım alarak.*/
{
  public override void lIfttheweIght()
    {
        base.lIfttheweIght();
        Console.WriteLine("Lift the weight with shoulder");
    }

}