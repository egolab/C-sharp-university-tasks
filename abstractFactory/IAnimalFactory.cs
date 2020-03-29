namespace abstractFactory
{
    public interface IAnimalFactory
    {
        abstract Animal CreateDomesticAnimal();
        abstract Animal CreateWildAnimal();
        abstract Animal Create(string type, string color, double weight, int speed);
    }
}
