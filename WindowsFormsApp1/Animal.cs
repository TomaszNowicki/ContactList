using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZwierzyniec

{
    class Animal
    {
        

        public string Name { get; set; }
        public string Breed { get; set; }
        public string Age { get; set; }
       
        public Animal()

        {
            Name = "bezimienny";
            Breed = "nowa rasa";
            Age = "0";            
        }
        public Animal(string name, string breed, string age)
        {
            Name = name;
            Breed = breed;
            Age = age;     
        }
        public override string ToString()
        {
            string output = String.Empty;

            output += String.Format("{0}, {1}, {2} lat", Breed, Name, Age);
          
            return output;
        }

    }// koniec klasy
}// koniec namespace
