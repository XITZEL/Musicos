class Musico
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
     public  virtual void Toca()//Vamos a redifinirlo
    {
        Console.WriteLine($"{Nombre} tocando su instrumento");
    }
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
        Musico Humbe = new Musico("Humbe");
        Humbe.Saluda();
        Humbe.Toca();
        //Lista de musico
       List<Musico> Morat = new List<Musico> ();
       //Poliformi
       Morat.Add(new Musico("Isaza"));
       Morat.Add(new Musico("Villa") );
       Morat.Add(new Bajista("Simon ","Bajo electrico"));
       Morat.Add(new Baterista("Martin","Bateria"));
       //Ciclamos
       foreach(var m in Morat)
       {
            m.Saluda();
            m.Toca();
       }

    }
}