namespace COOCelular.classe
{
    public class Celular
    {
        //Atributos
        public string cor;

        public string modelo;

        public string tamanho;

        public bool ligado;

        //Metodos

        public string Ligar(int numero)
        {
            string ligar = "ligando para o numero "+numero+" ...";
            
            return ligar;
        }

        public string Mensagem(string msg)
        {
            string mensagem = "Mensagem enviada  para "+msg;

            return mensagem;
        }
    


    }


}