using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    
    interface IFactory<Brand> where Brand : IBrand
    {
        IBag CreateBag();
        IShoes CreateShoes();
    }

    //Concrete Factories
    class Factory<Brand> : IFactory<Brand> where Brand : IBrand, new()
    {
        public IBag CreateBag()
        {
            return new Bag<Brand>();
        }

        public IShoes CreateShoes()
        {
            return new Shoes<Brand>();
        }
    }

    //interface IProductA
    interface IBag
    {
        string Material
        {
            get;
        }
    }

    //interface IProductB
    interface IShoes
    {
        int Price
        {
            get;
        }
    }

    //All concrete ProductA's
    class Bag<Brand> : IBag where Brand : IBrand, new()
    {
        private Brand myBrand;

        public Bag()
        {
            myBrand = new Brand();
        }

        public string Material
        {
            get 
            { 
                return myBrand.Material; 
            } 
        }
    }

    //All concrete ProductB's
    class Shoes<Brand> : IShoes where Brand : IBrand, new()
    {
        private Brand myBrand;

        public Shoes()
        {
            myBrand = new Brand();
        }

        public int Price
        {
            get
            {
                return myBrand.Price;
            }
        }
    }

    //An interface for all brands
    interface IBrand
    {
        int Price { get; }
        string Material { get; }
    }

    class Gucci : IBrand
    {
        public int Price
        {
            get
            {
                return 1000;
            }
        }
        public string Material
        {
            get
            {
                return "Crocodile skin";
            }
        }
    }

    class Poochy : IBrand
    {
        public int Price
        {
            get
            {
                return new Gucci().Price / 3;
            }
        }
        public string Material
        {
            get
            {
                return "Plastic";
            }
        }
    }

    class Groundcover : IBrand
    {
        public int Price
        {
            get
            {
                return 2000;
            }
        }
        public string Material
        {
            get
            {
                return "South african leather";
            }
        }
    }

    class Client<Brand> where Brand : IBrand, new()
    {
        public void ClientMain() //Ifactory<Brand> factory)
        {
            IFactory<Brand> factory = new Factory<Brand>();

            IBag bag = factory.CreateBag();
            IShoes shoes = factory.CreateShoes();

            Console.WriteLine("I Bought a bag which is made from " + bag.Material);
            Console.WriteLine("I Bought some shoes which cost " + shoes.Price);
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            //Call Client twice

            new Client<Poochy>().ClientMain();
            new Client<Gucci>().ClientMain();
            new Client<Groundcover>().ClientMain();
            Console.ReadKey();
        }
    }
}
