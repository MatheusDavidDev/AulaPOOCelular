namespace Aula_02.classes
{
    public class Aluno
    {
        //Atributos
        public string nome;
        public string curso;
        public string rg;
        public int idade;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        //Metodos
        public float VerMediaAluno()
        {
             return this.mediaFinal;
             /*this = chama ele mesmo ou seja
              no meu caso ele exibe a media final dele mesmo*/
            //Exibe o valor dele mesmo 
        }

        public float VerMensalidade()
        {
            float valor;

            if(this.bolsista == true && this.mediaFinal >= 8)
            {
            valor = this.valorMensalidade * 0.5f; //0.5f vale por 50% 
            }else
            {
            valor = this.valorMensalidade;   
            }

            return valor;

        }
    }
}