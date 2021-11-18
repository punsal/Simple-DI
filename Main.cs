using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Dependency Injection Example");

    var dragonFire = new DragonFire();
    var dragonIce = new DragonIce();

    dragonFire.Skill.Execute();
    dragonIce.Skill.Execute();
  }
}

public class FireSkill{
  private string _message = "Fire";

  public void Execute(){
    Console.WriteLine($"Skill is used : {_message}");
  }
}

public class IceSkill{
  private string _message = "Ice";

  public void Execute(){
    Console.WriteLine($"Skill is used : {_message}");
  }
}

public class DragonFire{
  private FireSkill _skill;

  public FireSkill Skill{get => _skill;}

  public DragonFire(){
    _skill = new FireSkill();
  }
}

public class DragonIce{
  private IceSkill _skill;

  public IceSkill Skill{get => _skill;}

  public DragonIce(){
    _skill = new IceSkill();
  }
}