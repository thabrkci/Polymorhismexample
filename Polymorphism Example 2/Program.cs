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
    public override void lIfttheweIght()
    {
        //base.lIfttheweIght();
        Console.WriteLine("Lift the weight with chest for chest");
    }
}

class Shoulder:bodybuıld
{
  public override void lIfttheweIght()
    {
        base.lIfttheweIght();
        Console.WriteLine("Lift the weight with shoulder");
    }

}