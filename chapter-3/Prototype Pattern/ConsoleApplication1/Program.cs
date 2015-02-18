using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;


namespace ConsoleApplication1
{
    [Serializable()]
    public class Description{
        public string Data{get; set;}

        public Description(string amount)
        {
            Data = amount;
        }

        public override string ToString()
        {
            return Data;
        }
       
    }

    [Serializable()]
    public abstract class ProductPrototype
    {
        public decimal Price { get; set; }
        public Description Description;

        public ProductPrototype(decimal price, string description)
        {

            Description = new Description(description);
            Price = price;
        }

        public ProductPrototype DeepCopy()
        {
            return Do(this);
        }

        public static T Do<T>(T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.");
            }

            // Don't serialize a null object, simply return the default for that object
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }

        public ProductPrototype Clone()
        {
            return (ProductPrototype) this.MemberwiseClone(  );
        }
    }

    // Milk prototype.
    [Serializable()]
    public class Milk : ProductPrototype
    {
        public Milk(decimal price, string description)
            : base(price, description)
        {

        }

        public override string ToString()
        {
            return this.Price + " --- " + this.Description;
        }
    }


    // Bread.
    [Serializable()]
    public class Bread : ProductPrototype
    {
        public Bread(decimal price,  string description)
            : base(price, description)
        {

        }

        public override string ToString()
        {
            return this.Price + " --- " + this.Description;
        }
     
    }

    [Serializable()]
    public class Supermarket
    {
        public Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();

        public void AddProduct(string key, ProductPrototype product)
        {
            _productList.Add(key, product);
        }

        public ProductPrototype GetProduct(string key)
        {
            return _productList[key];
        }
    }

    [Serializable()]
    class Program
    {
        static void Main(string[] args)
        {
            
            Supermarket supermarket = new Supermarket();
            supermarket.AddProduct("Milk", new Milk(1m,  "Something from a cow."));
            supermarket.AddProduct("Bread", new Bread(1.10m,  "Combination of wheat and water."));

             /*
            // This is what happens in the code below this commentblock.
            //  Normal Clone/Copy.
            
              var clone = supermarket.GetProduct("Bread").Clone();
              clone.Description.Data = "This description is changed! (Bread)";
            

             
             // Deep Copy
              
              var cloneDeep = supermarket.GetProduct("Milk").DeepCopy(); 
              cloneDeep.Description.Data = "This description is changed! (Milk)";
              
            */
            var clone = supermarket.GetProduct("Bread").Clone();

            Console.WriteLine("\n\n-------------------------------- Normal Copy: --------------------------------");
            Console.WriteLine("\n\n Before: \n -----------------");
            Console.WriteLine(" Clone: " + clone);
            Console.WriteLine(" Prototype: " + supermarket.GetProduct("Bread"));

         
            Console.WriteLine("\n [ Changing the description of the clone! ]");
            clone.Description.Data = "This description is changed! (Bread)";

           
            Console.WriteLine("\n\n After: \n -----------------");
            Console.WriteLine(" Clone: " + clone + "             <-- Changed!");
            Console.WriteLine(" Prototype:" + supermarket.GetProduct("Bread") + "          <-- Changed!");


            var cloneDeep = supermarket.GetProduct("Milk").DeepCopy();
            
            Console.WriteLine("\n\n-------------------------------- Deep Copy: --------------------------------");
            Console.WriteLine("\n\n Before: \n -----------------");
            Console.WriteLine(" Clone: " + cloneDeep);
            Console.WriteLine(" Prototype: " + supermarket.GetProduct("Milk"));

          
            Console.WriteLine("\n [ Changing the description of the clone! ]");
            cloneDeep.Description.Data = "This description is changed! (Milk)";

         
            Console.WriteLine("\n\n After: \n -----------------");
            Console.WriteLine(" Clone: " + clone + "             <-- Changed!");
            Console.WriteLine(" Prototype: " + supermarket.GetProduct("Milk") + "                       <-- Not Changed!");

            // Exit on keypress.
            Console.ReadKey();
          
        }
    }
}
