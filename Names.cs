using System;

namespace persons
{
    public class Names
    {
        // Propiedades
        private string firstName;
        private string secondName;

        // Esto solo es un campo
        public int age;

        // Puedes declarar un propiedad de las siguientes maneras
        // Declarando primero el nombre y el tipo de la propiedad
        private string lastName;

        // Defines la pripiedad con lo siguiente
        public string LastName { get; set; }

        // O simplemente podemos declarar la propiedad directamente
        public string aliasName { get; set; }

        // De igual forma podemos limitar la propiedad a solo devolver su valor
        public string otherAliasName { get; }

        string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                Console.WriteLine("Asignando nuevo nombre");
                firstName = value;
            }
        }

        public string SecondName
        {
            get 
            {
                return secondName;
            }

            set 
            {
                Console.WriteLine("Cambiando tu nombre:");
                secondName = value;
            }
        }

        public void GetName()
        {
            Console.WriteLine($"Hola mi nombre es {firstName} bienvenido usuario...");
        }

        public void SetName(string newName)
        {   
            Console.WriteLine("Estamos cambiando el nombre de este ente viviente...");
            firstName = newName;
            Console.WriteLine($"Tu nombre será ... {firstName}");
        }
    }
}