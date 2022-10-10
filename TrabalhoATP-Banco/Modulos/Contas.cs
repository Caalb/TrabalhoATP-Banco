using TrabalhoATP_Banco;

public class Contas {

    public static void contaCorrente(Tuple<int, double, double> tuplaResultado) {

        int tipoConta = tuplaResultado.Item1;
        double saldo = tuplaResultado.Item2;
        double _limiteChequeEspecial = tuplaResultado.Item3;

        Console.WriteLine("INFORME O QUE SERÁ REALIZADO NA CONTA");
        Console.WriteLine("1 - CONSULTAR SALDO \n2 - REALIZAR SAQUE \n3 - REALIZAR DEPÓSITO \n4 - PAGAR CONTA \n5 - REALIZAR TRANSFÊRENCIA \n 0 - FINALIZAR");

        int instrucao = int.Parse(Console.ReadLine());
        switch (instrucao)
        {
            case 1:
                Console.WriteLine($"SEU SALDO É: {saldo}");

                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial));
                break;
            case 2:
                Console.WriteLine("QUAL VALOR DO SAQUE?");
                double saque = double.Parse(Console.ReadLine());

                if (saldo < saque)
                {
                    Console.WriteLine("SALDO INSUFICIENTE");
                }
                else
                {
                    saldo -= saque;
                    Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                }
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial));
                break;
            case 3:
                Console.WriteLine("QUAL VALOR DO DEPÓSITO?");
                double deposito = double.Parse(Console.ReadLine());
                saldo += deposito;
                Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial));
                break;
            case 4:
                Console.WriteLine("QUAL VALOR DA CONTA QUE DESEJA PAGAR?");
                double valorConta = double.Parse(Console.ReadLine());

                if (saldo < valorConta)
                {
                    Console.WriteLine("SALDO INSUFICIENTE PARA TRANSFERÊNCIA.");
                }
                else
                {
                    saldo -= valorConta;

                    Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                }
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial));
                break;
            case 5:
                Console.WriteLine("QUAL CONTA QUE VOCÊ DESEJA REALIZAR TRANSFERÊNCIA?");
                int numeroConta = int.Parse(Console.ReadLine());

                Console.WriteLine("QUAL VALOR DA TRANSFERÊNCIA?");
                double valorTransferencia = double.Parse(Console.ReadLine());

                if (saldo < valorTransferencia)
                {
                    Console.WriteLine("SALDO INSUFICIENTE PARA TRANSFERÊNCIA.");
                }
                else
                {
                    saldo -= valorTransferencia;
                    Console.WriteLine($"TRANSFERÊNCIA REALIZADA COM SUCESSO PARA A CONTA: {numeroConta}");
                }
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial));
                break;
            case 6:
                if (tipoConta == 2)
                {
                    Console.WriteLine("MOSTRAR LIMITE CHECK ESPECIAL");
                    Console.WriteLine($"SEU LIMITE È 1000");
                }
                if (tipoConta == 3)
                {
                    Console.WriteLine("MOSTRAR SALDO CONTA POUPANÇA");
                }
                break;
            case 0:
                Console.WriteLine("VOCÊ REALMENTE DESEJA ENCERRAR?");
                Console.WriteLine("1 - SIM \n2 - NÃO");

                int encerrarSimOuNao = int.Parse(Console.ReadLine());
                if (encerrarSimOuNao == 2)
                {
                    Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial));
                }
                break;
        }
    }



    public static void ContaCorrenteComChequeEspecial(Tuple<int, double, double> tuplaResultado) {
        int tipoConta = tuplaResultado.Item1;
        double saldo = tuplaResultado.Item2;
        double limiteChequeEspecial = tuplaResultado.Item3;


        Console.WriteLine("INFORME O QUE SERÁ REALIZADO NA CONTA");
        Console.WriteLine("1 - CONSULTAR SALDO \n2 - REALIZAR SAQUE \n3 - REALIZAR DEPÓSITO \n4 - PAGAR CONTA \n5 - REALIZAR TRANSFÊRENCIA \n6- CONSULTAR SALDO CHEQUE ESPECIAL \n0- ENCERRAR");
        int instrucao = int.Parse(Console.ReadLine());
        switch (instrucao)
        {
            case 1:
                Console.WriteLine($"SEU SALDO É: {saldo}");

                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial));
                break;
            case 2:
                Console.WriteLine("QUAL VALOR DO SAQUE?");
                double saque = double.Parse(Console.ReadLine());

                if (saldo + limiteChequeEspecial <= saque)
                {
                    Console.WriteLine("SALDO INSUFICIENTE");
                }
                else if (saque <= saldo)
                {
                    saldo -= saque;
                    Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                }
                else if (saldo + limiteChequeEspecial > saque)
                {
                    int respostaUsuarioUtilizarCheque = 0;
                    do
                    {
                        Console.WriteLine($"SEU SALDO DE {saldo} É INSUFICIENTE, DESEJA UTILIZAR {saque - saldo} CHEQUE ESPECIAL??");
                        Console.WriteLine("1 - SIM \n2 - NÃO");
                        respostaUsuarioUtilizarCheque = int.Parse(Console.ReadLine());
                    } while (respostaUsuarioUtilizarCheque > 2);

                    if (respostaUsuarioUtilizarCheque == 1)
                    {
                        limiteChequeEspecial = limiteChequeEspecial - (saque - saldo);
                        saldo = 0;
                        Console.WriteLine($"SEU SALDO É DE: {saldo}");
                        Console.WriteLine($"SEU LIMITE PARA CHEQUE ESPECIAL ATUAL: {limiteChequeEspecial}");
                    }
                    else
                    {
                        Console.WriteLine("SAQUE NÃO REALIZADO");
                        Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial));
                    }
                }

                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial));
                break;
            case 3:
                Console.WriteLine("QUAL VALOR DO DEPÓSITO?");
                double deposito = double.Parse(Console.ReadLine());
                saldo += deposito;
                Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial));
                break;
            case 4:
                Console.WriteLine("QUAL VALOR DA CONTA QUE DESEJA PAGAR?");
                double valorConta = double.Parse(Console.ReadLine());

                if (saldo < valorConta)
                {
                    Console.WriteLine("SALDO INSUFICIENTE PARA TRANSFERÊNCIA.");
                }
                else
                {
                    saldo -= valorConta;

                    Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                }
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial));
                break;

            case 5:
                Console.WriteLine("QUAL CONTA QUE VOCÊ DESEJA REALIZAR TRANSFERÊNCIA?");
                int numeroConta = int.Parse(Console.ReadLine());

                Console.WriteLine("QUAL VALOR DA TRANSFERÊNCIA?");
                double valorTransferencia = double.Parse(Console.ReadLine());

                if (saldo < valorTransferencia)
                {
                    Console.WriteLine("SALDO INSUFICIENTE PARA TRANSFERÊNCIA.");
                }
                else
                {
                    saldo -= valorTransferencia;
                    Console.WriteLine($"TRANSFERÊNCIA REALIZADA COM SUCESSO PARA A CONTA: {numeroConta}");
                }
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial));
                break;
            case 6:
                Console.WriteLine("VOCÊ REALMENTE DESEJA ENCERRAR?");
                Console.WriteLine("1 - SIM \n2 - NÃO");

                int encerrarSimOuNao = int.Parse(Console.ReadLine());
                if (encerrarSimOuNao == 2)
                {
                    Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial));
                }
                break;
        }
    }
}
