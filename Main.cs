using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Dependency Injection Example");

    Dragon dragonFire = new DragonFire(new FireSkill());
    Dragon dragonIce = new DragonIce(new IceSkill());

    dragonFire.UseSkill();
    dragonIce.UseSkill();
  }
}

public abstract class Skill{
  protected abstract string Message{get;}

  public void Execute(){
    Console.WriteLine($"Skill is used : {Message}");
  }
}

public class NullSkill : Skill{
  protected override string Message{get => "";}
}

public class FireSkill : Skill{
  protected override string Message{get => "Fire";}
}

public class IceSkill :Skill{
  protected override string Message{get => "Ice";}
}

public class Dragon{
  protected Skill skill;

  public Dragon(){
    skill = new NullSkill();
  }

  public void UseSkill(){
    skill.Execute();
  }
} 

public class DragonFire : Dragon{
  public DragonFire(Skill skill){
    this.skill = skill;
  }
}

public class DragonIce : Dragon{
  public DragonIce(Skill skill){
    this.skill = skill;
  }
}