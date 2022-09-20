public class Libro(){
    private String titulo= "Gorge and Manu";
    private String autor= "fonsi y el xulo";
    private int numEjemplaresLibro= 150000;
    private int numEjemplaresPrestados = 25000;

    public Libro(String titulo, String autor, int numEjemplaresLibro, int numEjemplaresPrestados){
        this.titulo= titulo;
        this.autor=autor;
        this.numEjemplaresLibro=numEjemplaresLibro;
        this.numEjemplaresPrestados=numEjemplaresPrestados;
    }

            public string titulo {
            get { return titulo; }
            set { titulo = value; }
            }

            public string autor {
            get { return autor; }
            set { autor = autor; }
            }

            public int numEjemplaresLibro {
            get { return numEjemplaresLibro; }
            set { numEjemplaresLibro = value; }
            }

            public int numEjemplaresPrestados {
            get { return numEjemplaresPrestados; }
            set { numEjemplaresPrestados = value; }
            }


    funtion prestamo(){
            if(this.numEjemplaresLibro>=this.numEjemplaresPrestados){
                Console.WriteLine("no hay suficientes ejemplares disponibles para prestar");
                return false;
            }else{
                this.numEjemplaresPrestados++;
               return true;
            }    
    }

    funtion devolucion(){
        if(this.numEjemplaresLibro<=this.numEjemplaresPrestados){
                Console.WriteLine("no hay suficientes ejemplares disponibles para prestar");
                return false;
            }else{
                this.numEjemplaresPrestados--;
               return true;
            }
    }

    funtion mostrar(){
       Console.WriteLine("titulo del libro: "+titulo+", autor del libro:" +autor+"libors disponibles"+numEjemplaresLibro+", libros prestados: "+numEjemplaresPrestados); 


    }
a









}