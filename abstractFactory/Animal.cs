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

    public class Dog: Animal
    {
        public Dog(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }

        public override string ShowData()
        {
            return "Dog";
        }

        public override string ToString()
        {
            return "Dog\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }

    public class Lion : Animal
    {
        public Lion(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }

        public override string ShowData()
        {
            return "Lion";
        }

        public override string ToString()
        {
            return "Lion\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }

    public class Falcon : Animal
    {
        public Falcon(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }
        public override string ShowData()
        {
            return "Falcon";
        }

        public override string ToString()
        {
            return "Falcon\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }

    public class Parrot : Animal
    {
        public Parrot(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }

        public override string ShowData()
        {
            return "Parrot";
        }
        public override string ToString()
        {
            return "Parrot\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }

    public class Shark : Animal
    {
        public Shark(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }

        public override string ShowData()
        {
            return "Shark";
        }
        public override string ToString()
        {
            return "Lion\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }

    public class AquariumFish : Animal
    {
        public AquariumFish(string c, double w, int s)
        {
            color = c;
            weight = w;
            speed = s;
        }

        public override string ShowData()
        {
            return "Aquarium fish";
        }

        public override string ToString()
        {
            return "Aquarium Fish\nColor: " + color + "\nWeight: " + weight + "\nSpeed: " + speed;
        }
    }
}
