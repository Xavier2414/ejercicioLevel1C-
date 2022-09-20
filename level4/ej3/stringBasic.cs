class StringBasic{
    
    private String cadena ="hola que tal esta tatico";


    public StringBasic(String cadena){
        this.cadena=cadena;

    }

    public String cadena {
            get { return cadena; }
            set { cadena = value; }
            }



    funtion contarVocales(){
        for(int x=0;x<this.cadena.length();x++) {
            if ((this.cadena.charAt(x)=='a') || (this.cadena.charAt(x)=='e') || (this.cadena.charAt(x)=='i') || (this.cadena.charAt(x)=='o') || (this.cadena.charAt(x)=='u')){ 
                contador++;
            }
        }
        Console.WriteLine("La cadena de palabras: " + cadena + "    | contiene " + contador + " vocales"); 
    }



    funtion contarConsonates(){
        int consonantes = 0;
		    for (int x = 0; x < this.cadena.length(); x++) {
			    char letra = this.cadena.charAt(x);
			        if (esConsonante(letra)) {
				        consonantes++;
			            }
		        }

         Console.WriteLine("La cadena de palabras: " + this.cadena + "    | contiene " + consonantes + " vocales");        
    }

    public static boolean esConsonante(char letra) {
		return "bcdfghjklmnñpqrstvwxyz".contains(String.valueOf(letra).toLowerCase());
	}



    funtion contarPalabras(){
        String[] palabras = this.cadena.split("\\s+");
        Console.WriteLine("Las palabras contadas son:" palabras.length);
    }


    funtion contarCarcters(){
       int totalCharacters = 0;
        char temp;
        for (int i = 0; i < this.cadena.length(); i++) {

            temp = this.cadena.charAt(i);
            if (temp == '‘' ||temp == '(' ||temp == ')' ||temp == '*'||temp == ','||temp == '-'||temp == '/')
                totalCharacters++;
        }

        Console.WriteLine("Las caracteres contados son:" totalCharacters);

    }

    funtion buscarParamentroContar(){
        int posicion; 
        int contador = 0;

            Console.WriteLine("Caracter a buscar:" );
              String text;
            text=Console.ReadLine();
     
        posicion = cadena.indexOf(text);
        while (posicion != -1) { 
            contador++;                                         
            posicion = this.cadena.indexOf(text, posicion + 1);
        }
         Console.WriteLine("Los caracteres contados son:" contador);
    }


    funtion invertir(){
        		String invertida = "";
		// Recorremos la original del final al inicio
		for (int i = this.cadena.length() - 1; i >= 0; i--) {
			// Y vamos concatenando cada carácter a la nueva cadena
			invertida += this.cadena.charAt(i);
		}
		Console.WriteLine("Cadena original: " + this.adena);
		Console.WriteLine("Cadena invertida: " + invertida);
    }

    funtion remplazar (){

          String replacado = this.cadena.replaceAll("*");

        Console.WriteLine( "Cadena remplacada: " +replacado);
    }


}