using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Dependency Injection Example");

    Dragon dragonFire = new DragonFire();
    Dragon dragonIce = new DragonIce();

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

  public void UseSkill(){
    skill.Execute();
  }
} 

public class DragonFire : Dragon{
  public DragonFire(){
    skill = new FireSkill();
  }

  public DragonFire(Skill skill){
    this.skill = skill;
  }
}

public class DragonIce : Dragon{
  public DragonIce(){
    skill = new IceSkill();
  }

  public DragonIce(Skill skill){
    this.skill = skill;
  }
}