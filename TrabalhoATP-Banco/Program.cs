using TrabalhoATP_Banco.Modulos;

namespace TrabalhoATP_Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicializarModulos(InicializacaoSistema.start());
        }

        public static void inicializarModulos(Tuple<int, double, double> tuplaResultado)
        {

            int tipoConta = tuplaResultado.Item1;
            double saldo = tuplaResultado.Item2;
            double limiteChequeEspecial = tuplaResultado.Item3;
            
            
            if (tipoConta == 1)
            {
                Contas.contaCorrente(tuplaResultado);
               
            }
            else if (tipoConta == 2)
            {
                Contas.contaCorrente(tuplaResultado);
            }

        }
    }
}