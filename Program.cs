using System;

namespace TV
{
    class TV{
        private string serie;
        private string marca;
        private int pulgadas;
        private double precio;
        public string Setserie {get{return serie;} set{serie = value;}}
        public string Setmarca {get{return marca;} set{marca = value;}}
        public int Setpulgadas {get{return pulgadas;} set{pulgadas = value;}}
        public double Setprecio{get{return precio;} set{precio = value;}}

        public void PrecioSo(double precio){
            Console.WriteLine("\nEl precio en soles es " + precio * 0.0639);
        }
        public void TMarca(string marca){
            Console.WriteLine("La marca del televison es {0}\n",marca);
        }
        public void Mostrar(){
            Console.WriteLine("La TV es de serie {0}", serie);
            Console.WriteLine("La TV tiene {0} pulgadas", pulgadas);
            Console.WriteLine("La Tv es de la marca {0}", marca);
            Console.WriteLine("La TV tiene un precio de {0}", precio);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            tv.Setserie = "2132231";
            tv.Setpulgadas = 23;
            tv.Setprecio = 200;
            tv.Setmarca = "Samsung";
            tv.Mostrar();
            tv.PrecioSo(tv.Setprecio);
            tv.TMarca(tv.Setmarca);
        }
    }
}
