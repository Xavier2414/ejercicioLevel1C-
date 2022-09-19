using System;

public static void main((string[] args){

   private string nombre = 'Xavier';
   private int edat = 20;
   private string DNI = '12345678A';

    public constructor (string  nombre, int edat, string DNI){

    }

    funtion mostrar(string  nombre, int edat, string DNI){
        Console.WriteLine("el Nombre: "+nombre+" ,tiene: "+ edat+" DNI: "+DNI );
    }
    funtion esMayorDeEdad( string  nombre, int edat, string DNI){ 
        if(edat <= 18){
             Console.WriteLine("Es mayor de edat");
        }else{
            Console.WriteLine("Es menor de edat");
        }
    }  

}


using System;

public static void main((string[] args){

public class Cuenta{
   private string titular ='Xavi';
   private int cantidat = 1949 ;

   public constructor( string titular, string cantidat){

   }


           public string titular {
            get { return titular; }
            set { titular = value; }
            }

            public int cantidat {
            get { return cantidat; }
            set { cantidat = value; }
            }

    funtion mostrar(string titular, string cantidat){
        Console.WriteLine("el titular: "+titular+" ,cantidat: "+ cantidat);
    }

    funtion ingresar(int cantidat){
       
        if(cantidat<0){
            cantidat + 195;
        }else{
            Console.WriteLine("saldo negativo");
        }
    }

        funtion retirar(int cantidat){
       
        if(cantidat<0){
            cantidat - 80;
        }else{
            Console.WriteLine("no hay dinero ");
        }
    }

}

}