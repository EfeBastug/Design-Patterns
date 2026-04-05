public abstract class Duck
{
    protected IFlyBehaviour flyBehaviour;
    protected IQuackBehaviour quackBehaviour;
    
    public abstract void Fly();
    public abstract void Quack();
    public abstract void Swim();

    public abstract void setFlyBehaviour(IFlyBehaviour fb);
    public abstract void setQuackBehaviour(IQuackBehaviour qb);
}