abstract class Musico     //Las clases abtractas solo pueden generar herencia, pero no pueden crear objetos directos

{
    //propiedades
   public string Nombre{get;set;}
   
   //Constructor
   public Musico(string n){Nombre=n;}
    //Metodos
    public void Saluda()
    {
        Console.WriteLine($"Hola, soy {Nombre}");
    }
    //Los metodos abstractos 
    //Para implementar metodos abtractos debemos usar la palabra reservada "overide"
     public /*virtual*/abstract void Toca();//Vamos a redifinirlo
    /*{
        Console.WriteLine($"{Nombre} tocando su instrumento");
    }*/
}
    //Clases
     class Bajista: Musico
    {
        //Propiedad
        public string Bajo{get;set;}
        //Constructor llamar el de la clase base
        public Bajista(string n, string b):base(n){Bajo=b;}
                                        //Palabra reservada para herencia
        //Metodo
        //Redifinimos el metodo Toca
        public override void Toca()
        {
            Console.WriteLine($"{Nombre}tocando su {Bajo}");
        }
    }
    class Baterista:Musico
    {
        //Propiedades
        public string Bateria{get;set;}
        //Constructor llamar el metodo de la clase base
        public Baterista(string n,string ba):base(n){Bateria=ba;}
        //Metodo
        //Redifinimos
        public override void Toca()
        {
            Console.WriteLine($"{Nombre} tocando su {Bateria}");
        }
    }

   
internal class Program
{
    private static void Main(string[] args)
    {
        //No podemos tener objetos abtracto en este caso "Musicos"
        //Musico Humbe = new Musico("Humbe");
        //Humbe.Saluda();
        //Humbe.Toca();
        //Lista de musico
        //No puedo tener objetos abtractos pero si referencia
       List<Musico> Morat = new List<Musico> ();
       //Polimorfismo
       //Morat.Add(new Musico("Juan Pablo Isaza"));
       //Morat.Add(new Musico("Juan Pablo Villamil") );
       Morat.Add(new Bajista("Simon Vargas Morales ","Bajo electrico"));
       Morat.Add(new Baterista("Martin Vargas Morales","Bateria"));
       //Ciclamos
       foreach(var m in Morat)
       {
            m.Saluda();
            m.Toca();
       }

    }
}