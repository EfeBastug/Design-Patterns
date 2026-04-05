public class MallardDuck : Duck
{
    public MallardDuck()
    {
        flyBehaviour = new FlyWithWings();
        quackBehaviour = new QuackNormal();
    }

    public override void setFlyBehaviour(IFlyBehaviour fb)
    {
        flyBehaviour = fb;
    }

    public override void setQuackBehaviour(IQuackBehaviour qb)
    {
        quackBehaviour = qb;
    }

    public override void Fly()
    {
        flyBehaviour.Fly();
    }

    public override void Quack()
    {
        quackBehaviour.Quack();
    }

    public override void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}