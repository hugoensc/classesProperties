using System;
using persons;

namespace classesProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var firstPerson = new Names();
            firstPerson.SetName("Biohazard");
            firstPerson.GetName();

            Console.WriteLine("Ingresa tu nombre...");
            firstPerson.SecondName = Console.ReadLine();
            Console.WriteLine($"Tu nuevo nombre es: {firstPerson.SecondName}");


            // Los objetos son paso por referencia
            // por ejemplo el nombre de el objeto persona cambiara su propiedad
            // si pasamos como parametro el objeto a un método
            ChangeName(firstPerson);
            firstPerson.GetName();

            void ChangeName(Names person)
            {
                person.SetName("Cambio de nombre");
            }

            // en cambio si pasamos un tipo valor como parametro su valor no cambiara 
            // conservara su propio valor solo se pasa una copia como parametro
            // ejemplo

            int num = 6;
            Console.WriteLine("Este es el valor del número }");

            ChangeValue(num);


            void ChangeValue(int num)
            {
                num++;
            }

        }


    }
}
