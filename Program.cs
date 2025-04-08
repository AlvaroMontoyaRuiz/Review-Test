using System.Buffers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person PetOwner = new Person();
            PetOwner.SetName("John Doe");
            PetOwner.SetEmail("gmail.com");
            PetOwner.Display_info();

            Person PetOwner2 = new Person("Kate", "Yahho.com");

            PetOwner2.Display_info();
            PetOwner.Display_info();

            Console.WriteLine("Email for owner 2 is "+ PetOwner2.GetEmail());    

            Dog Mydog = new Dog();
            Mydog.SetBreed("American");
            
            Dog yourdog = new Dog("Bulldog", "Tommy", "Dog", 5);

            string breed =Mydog.GetBreed();
            Console.WriteLine("Breed is mydog " + breed);
            Console.WriteLine("yorDog name is " + yourdog.GetName());

            Console.WriteLine(yourdog.make_sound());
        }

    }

    class Person
    {
        private string Name;
        private string Email;

        public Person()
        {
            Name = "";
            Email = "";

        }
        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public void Display_info()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);   
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
    }

    class Pet
    {
        private string Name;
        private string Species;
        private int Age;
        public Pet()
        {
            Name = "";
            Species = "";
            Age = 0;
        }
        public Pet(string name, string species, int age)
        {
            Name = name;
            Species = species;
            Age = age;
        }
        public string make_sound()
        {
            return "Sound is made";

        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetSpecies(string species)
        {
            Species = species;
        }
        public string GetSpecies()
        {
            return Species;
        }
        public void SetAge(int age)
        {
            Age = age;
        }
        public int GetAge()
        {
            return Age;
        }
    }

    class Dog : Pet
    {
        private string Breed;
        public Dog() :base()
        {
            Breed = "";
        }

        public Dog(string breed ,string name, string species, int age) : base(name,species,age)
        {
            Breed = breed;
        }
        new public string make_sound()
        {
            return base.make_sound() +" Woof Woof";
        }
        public void SetBreed(string breed)
        {
            Breed = breed;
        }
        public string GetBreed()
        {
            return Breed;
        }

    }

    class Cat: Pet
    {
        private string Color;
        new public string make_sound()
        {
            return base.make_sound() + " Meow Meow";
        }

        public Cat() : base()
        {
            Color = "";
        }
        public Cat(string color, string name, string species, int age) : base(name, species, age)
        {
            Color = color;
        }

        public void SetColor(string color)
        {
            Color = color;
        }

        public string GetColor()
        {
            return Color;
        }



    }
}
