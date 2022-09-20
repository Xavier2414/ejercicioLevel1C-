class alumno(){

  private  String nom='';
  private  String cognom='';
  private String cicle_formatiu='';
  private String NIF ='';
  private  String Curs = '';

    public alumno(String nom, String cognom,String NIF, String cicle_formatiu, String Curs){
        this.nom =nom;
        this.cognom =cognom;
        this.cicle_formatiu= cicle_formatiu;
        this.NIF=NIF;
        this.curs=curs;
    }

      public String nom {
            get { return nom; }
            set { nom = value; }
            }
        public String cognom {
            get { return cognom; }
            set { cognom = value; }
            }
        public String cicle_formatiu {
            get { return cicle_formatiu; }
            set { cicle_formatiu = value; }
            }
         public String Curs {
            get { return Curs; }
            set { Curs = value; }
            }
        public String NIF {
            get { return NIF; }
            set { NIF = value; }
            }

    funtion equal(){
        String alumno='hola';
        String cognom ='epa';
        String nif ='b25838928';

        if(this.alumno=alumno && this.cognom=cognom &&this.NIF=nif ){
             Console.WriteLine('es equal'); 
        }
    }

}


public static void Main(){

      var auto = new alumno("Manu", "tatico", "daw", "daw2");
      Console.WriteLine(auto.ToString());

    ArrayList array =new ArrayList();

    Console.WriteLine("+----------------------------------+");
    Console.WriteLine("|               Menu               |");
    Console.WriteLine("|                                  |");
    Console.WriteLine("|      Agregar[1]                  |");
    Console.WriteLine("|      Buscar [2]                  |");
    Console.WriteLine("|      Mostrar[3]                  |");
    Console.WriteLine("|      Salir  [4]                  |");
    Console.WriteLine("|                                  |");
    Console.WriteLine("+----------------------------------+");
    int Opcion;
    Opcion=Console.ReadLine();

    if(opcion ==1){

    Console.WriteLine("+----------------------------------+");
    Console.WriteLine("|                                  |"); 
    Console.WriteLine("|         Introducir String        |");
    Console.WriteLine("|                                  |"); 
    Console.WriteLine("+----------------------------------+");
    String text;
    text=Console.ReadLine();
        array.Add(text); 

    }else if(opcion ==3){
;
    Console.WriteLine("+----------------------------------+");
    Console.WriteLine("|                                  |"); 
    Console.WriteLine("|         Mostrar Arraylist        |");
    Console.WriteLine("|                                  |"); 
    Console.WriteLine("+----------------------------------+");
    Console.WriteLine("|" array                          "|");
    Console.WriteLine("+----------------------------------+");
    }
    else if(opcion ==2){
;
    Console.WriteLine("+----------------------------------+");
    Console.WriteLine("|                                  |"); 
    Console.WriteLine("|          buscar Arraylist        |");
    Console.WriteLine("|                                  |"); 
    Console.WriteLine("+----------------------------------+");
    String buscar;
    buscar=Console.ReadLine()
    Console.WriteLine("+----------------------------------+");
    int buscararray = array.IndexOf( buscar );
    Console.WriteLine( "buscado :  ", buscar" encontrado: " buscararray );
    }
    else if(opcion ==2){
;
    Console.WriteLine("+----------------------------------+");
    Console.WriteLine("|                                  |"); 
    Console.WriteLine("|                Fin               |");
    Console.WriteLine("|                                  |"); 
    Console.WriteLine("+----------------------------------+");
   
    }


    







     

   }
}