namespace abstractFactory
{
    public class Animal
    {
        protected string color;
        protected double weight;
        protected int speed;
 
        public virtual string ShowData()
        {
            return "Unspecified animal";
        }
    }
}
