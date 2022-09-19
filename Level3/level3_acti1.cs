using System;

public class  CuentaJoven{

private String titular = 'fonsi';
private int cantidat = 5841;
private int edat = 20;


 public CuentaJoven(String titular, int cantidat, int edat){
        this.titular=titular;
        this.cantidat=cantidat;
        this.edat=edat;
 }

            public string titular {
            get { return titular; }
            set { titular = value; }
            }

           public string titular {
            get { return titular; }
            set { titular = value; }
            }

            public int edat {
            get { return edat; }
            set { edat = value; }
            }
    
    funtion esTitularValido(){
        if(this.edat<=18 && this.edat>=25){
            return false;
        }else{
            return true;
        }

    }

     funtion ingresar(int cantidat){
        if(this.edat<=18 && this.edat>=25){
         Console.WriteLine("No tinenes la edad requerida");
        }else{
             if(cantidat<0){
            cantidat + 195;
        }else{
            Console.WriteLine("saldo negativo");
        } 
        }
       
        
    }

     funtion retirar(int cantidat){
        if(this.edat<=18 && this.edat>=25){
         Console.WriteLine("No tinenes la edad requerida");
        }else{
       if(cantidat<0){
            cantidat - 80;
        }else{
            Console.WriteLine("no hay dinero ");
        } 
     }
     }


      funtion retirar(int cantidat){
        Console.WriteLine("el titular: "+titular+" ,cantidat: "+ cantidat+", Edat:"+edat );
      }


}