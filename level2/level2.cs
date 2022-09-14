using System;

public static void main((string[] args){

    private int capacidadMaxima ;
    private int cantidadActual ;


    public constructor(int cantidadActual, int capacidadMaxima){
        this.cantidadActual=0;
        this.cantidadActual=1000;
    }

    //cantidadActual
    get { return cantidadActual; }
    set { cantidadActual = value; }
    //capacidadMaxima
    get { return capacidadMaxima; }
    set { capacidadMaxima = value; }


    funtion llenarCafetera( int cantidadActual, int capacidadMaxima)){
        if(capacidadMaxima == cantidadActual){
            Console.WriteLine("cafetera llena");
        }else(){
          cantidadActual=1000;  
        }
        return cantidadActual;
    }

    funtion servirTaza(int cantidadActual, int capacidadMaxima){
        int taza =50;

        if(taza > cantidadActual){
            Console.WriteLine("no hay suficente cafe para servir una taza");
        }else{
             Console.WriteLine("sirviendo taza...");
             cantidadActual-taza;
        }
        return cantidadActual;

    }

    funtion vaciarCafetera(int cantidadActual, int capacidadMaxima){
        int vaciar =cantidadActual;

        if(cantidadActual == 0){
            Console.WriteLine("tetera vacia");
        }else{
            cantidadActual-vaciar;
        }
        return cantidadActual;
    }

    funtion agregarCafe(int cantidadActual, int capacidadMaxima){
            int cantidadcafe= 350;
        if (cantidadActual == 1000){
            Console.WriteLine("tetera esta llena");
        }else{
            cantidadActual+cantidadcafe;
        }

        return cantidadActual;
    }



}

///segundo


using System;

public static void Producto ((string[] args){

var b = new ProductoFresco.ProductoCongelado();
        Console.WriteLine(b.GetValue());


}


public class ProductoFresco 
{
    private string fecha ='09/05/2002';
    private string pais ='Italia';

public constructor(string fecha,string pais){

}

    get { return fecha; }
    set { fecha = value; }
    get { return pais; }
    set { pais = value; }

    funtion mostrar(){
         Console.WriteLine(" fehca: "+fecha+" ,pais: "+ pais);
    }
    
    return fehca, pais;
}


public class ProductoCongelado 
{
    private string temperatura ='1 grado';
    private string congelación ='1 grado';

public constructor(string fecha,string pais){

}

    get { return temperatura; }
    set { temperatura = value; }
    get { return congelación; }
    set { congelación = value; }

    funtion mostrar(){
         Console.WriteLine(" temperatura: "+temperatura+" ,congelación: "+ congelación);
    }
    
    return temperatura, congelación;
}


