namespace Polymorphism_Example_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO EXERCİSES 2!");
        bodyBuild body = new bodyBuild();
        body.lifttheWeight();
        Chest chest = new Chest();
        chest.lifttheWeight();
        Shoulder shoulder = new Shoulder();
        shoulder.lifttheWeight();  
    }
}
public class bodyBuild{
   public virtual void lifttheWeight()
  {
    Console.WriteLine("Lift the weight");
  }
}
public class Chest:bodyBuild{
    public override void lifttheWeight()/*Bodybuild sınıfından lifttheWeight(metodunu)kalıtım alarak
    Polymorphism uyguladık kaldır metodunu değiştirerek göğüs kası ile kaldır göğüs kası için yaptık*/
    {
        //base.lIfttheweIght();/*Bu kısmı yorum satırı olarak almamızın nedeni ağırlık kaldır metodunu göğüs kasına uyarlamak istediğimiz için lift the weight yer kaplayacağı ve fazlalık oluşturacağı için göğüs kasıyla beraber kaldır hedef bölge göğüs kası şeklinde yazdık.*/
        Console.WriteLine("Lift the weight with chest for chest");
    }
}
public class Shoulder:bodyBuild{
  public override void lifttheWeight()
    {
        base.lifttheWeight();
        Console.WriteLine("Lift the weight with shoulder");
    }
}
/*Göğüs kası için olan örneği burada omuz kası için  gerçekleştirdik aynı şekilde,
kalıtım alarak.*/