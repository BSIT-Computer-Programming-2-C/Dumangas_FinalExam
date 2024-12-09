using System;

namespace attributes
{
    public class person
    {
        private string _name;
        private int _age;
        private string _address;


        public person (string name, int age, string address)
        {
            this._name = name;
            this._age = age;
            this._address = address;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >=0)
                    _age = value;
                else 
                    throw new ArgumentException("Age connot be negative");
            }
                

         
        }

        public static void Main(string[] args)
        {
            person person = new person("Jericho Dumangas", 26, "Itogon, Benguet");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Address);
          
           
        }
        
              
    }


}

