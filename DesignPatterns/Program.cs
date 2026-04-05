using System;

class DesignPatterns{
    // Main Method
    public static void Main(){
        Duck mallard = new MallardDuck();
        mallard.Quack();
        mallard.Fly();

        Duck decoy = new DecoyDuck();
        decoy.Quack();
        decoy.setFlyBehaviour(new FlyWithWings());
        decoy.Fly();

    }
}
