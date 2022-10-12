using TrabalhoATP_Banco.Modulos;

namespace TrabalhoATP_Banco {
    internal class Program {
        static void Main(string[] args) {
            inicializarModulos(InicializacaoSistema.start());
        }

        public static void inicializarModulos(Tuple<int, double, double, int, double> tuplaResultado) {

            int tipoConta = tuplaResultado.Item1;
            double saldo = tuplaResultado.Item2;
            double limiteChequeEspecial = tuplaResultado.Item3;


            switch (tipoConta)
            {
                case 1:
                    Contas.contaCorrente(tuplaResultado);
                    break;
                case 2:
                    Contas.ContaCorrenteComChequeEspecial(tuplaResultado);
                    break;
                case 3:
                    Contas.ContaPoupanca(tuplaResultado);
                    break;
            }
        }
    }
}