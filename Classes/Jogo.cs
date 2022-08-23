using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace BibliotecaDejogos.Classes
{
    internal class Jogo
    {
        //ATRIBUTOS
        String titulo;
        int ano;
        String genero;
        int maxJogadores;
        int metacritic;

        static int numeroCadastro;
        int numeroCadastroAtual;
  

        //CONSTRUTORES
        public Jogo (String titulo, int ano, String genero,
                    int maxJogadores, int metacritic)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
            this.metacritic = metacritic;
            numeroCadastro++;
            this.numeroCadastroAtual = numeroCadastro;
        }

        public Jogo(String titulo, int ano, String genero,
                    int maxJogadores)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
            numeroCadastro++;
            this.numeroCadastroAtual = numeroCadastro;
        }

        //METODOS DE ACESSO
        //GETTER - RETORNA VALOR DO ATRIBUTO

        public String getTitulo ()
        {
            return this.titulo;
        }

        public int getAno ()
        {
            return this.ano;
        }

        public String getGenero ()
        {
            return this.genero;
        }

         public int getMaxJogadores ()
        {
            return this.maxJogadores;
        }

        public int getNumeroCadastroAtual(){
            return numeroCadastroAtual;
        }




















        //SETTER - MODIFICA VALOR DO ATRIBUTO
        public void setTitulo (String titulo)
        {
            if(titulo != "") { 
                this.titulo = titulo;
            }
        }

        public void setAno (int ano)
        {
            if(ano > 1950) { 
                this.ano = ano;
            }
        }

        public void setGenero (String genero)
        {
            if(genero != "") { 
                this.genero = genero;
            }
        }

         public void setMaxJogadores (int maxJogadores)
        {
                this.maxJogadores = maxJogadores;
            
        }
        public void setMetacritic (int metacritic)
        {
                this.metacritic = metacritic;
        }




    


    }
}
