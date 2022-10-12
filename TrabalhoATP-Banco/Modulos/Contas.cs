using System.ComponentModel.Design;
using TrabalhoATP_Banco;

public class Contas
{

    public static void contaCorrente(Tuple<int, double, double, int, double> tuplaResultado)
    {

        int tipoConta = tuplaResultado.Item1;
        double saldo = tuplaResultado.Item2;
        double _limiteChequeEspecial = tuplaResultado.Item3;
        int cont = tuplaResultado.Item4;
        double _saldoDevedorChequeEspecial = tuplaResultado.Item5;

        if (tipoConta == 1)
        {
            Console.WriteLine($"CONTA CORRENTE \nSALDO: {saldo} ");
            
        } else if (tipoConta == 2)
        {
            Console.WriteLine($"CONTA CORRENTE c/ CHEQUE ESPECIAL \nSALDO: R$ {saldo} - CHEQUE ESPECIAL:R$ {_limiteChequeEspecial} ");

        } else
        {
            Console.WriteLine($"CONTA POUPANÇA \nSALDO: {saldo} - RENDIMENTOS: *** ");

        }

        Console.WriteLine();
        Console.WriteLine("-------------");
        Console.WriteLine();
        Console.WriteLine("INFORME O QUE SERÁ REALIZADO NA CONTA");
        Console.WriteLine("1 - CONSULTAR SALDO \n2 - REALIZAR SAQUE \n3 - REALIZAR DEPÓSITO \n4 - PAGAR CONTA \n5 - REALIZAR TRANSFÊRENCIA");
        if (tipoConta == 2)
        {
            Console.WriteLine("6 - CONSULTAR CHEQUE ESPECIAL");
        }
        else if (tipoConta == 3)
        {
            Console.WriteLine("6 - CONSULTAR RENDIMENTOS");
        }
        Console.WriteLine("0 - FINALIZAR ");
        
        int instrucao = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (instrucao)
        {

            case 1:
                Console.WriteLine($"SEU SALDO É: {saldo}");

                Console.ReadKey();
                Console.Clear();
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, _saldoDevedorChequeEspecial));
                cont++;
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
                Console.ReadKey();
                Console.Clear();
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, _saldoDevedorChequeEspecial));
                cont++;
                break;
            case 3:
                Console.WriteLine("QUAL VALOR DO DEPÓSITO?");
                double deposito = double.Parse(Console.ReadLine());
                saldo += deposito;
                Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                Console.ReadKey();
                Console.Clear();
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, _saldoDevedorChequeEspecial));
                cont++;
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
                Console.ReadKey();
                Console.Clear();
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, _saldoDevedorChequeEspecial));
                cont++;
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
                Console.ReadKey();
                Console.Clear();
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, _saldoDevedorChequeEspecial));
                cont++;
                break;
            case 6:
                if (tipoConta == 2)
                {
                    Console.WriteLine("LIMITE CHEQUE ESPECIAL");
                    Console.WriteLine($"SEU LIMITE È {_limiteChequeEspecial}");
                }
                if (tipoConta == 3)
                {
                    Console.WriteLine("SALDO CONTA POUPANÇA");
                }
                Console.ReadKey();
                Console.Clear();
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, _saldoDevedorChequeEspecial));
                cont++;
                break;
            case 0:
                Console.WriteLine("VOCÊ REALMENTE DESEJA ENCERRAR?");
                Console.WriteLine("1 - SIM \n2 - NÃO");

                int encerrarSimOuNao = int.Parse(Console.ReadLine());
                if (encerrarSimOuNao == 2)
                {
                    Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, _saldoDevedorChequeEspecial));
                }
                break;
                
        }

    }

    public static void ContaCorrenteComChequeEspecial(Tuple<int, double, double, int, double> tuplaResultado) {
        int tipoConta = tuplaResultado.Item1;
        double saldo = tuplaResultado.Item2;
        double limiteChequeEspecial = tuplaResultado.Item3;
        int cont = tuplaResultado.Item4;
        double saldoDevedorChequeEspecial = tuplaResultado.Item5;

        Console.WriteLine($"CONTA CORRENTE c/ CHEQUE ESPECIAL \nSALDO: R$ {saldo} - CHEQUE ESPECIAL: R$ {limiteChequeEspecial} - SALDO DEVEDOR: R${saldoDevedorChequeEspecial}");
        Console.WriteLine("--------------------");

        Console.WriteLine("INFORME O QUE SERÁ REALIZADO NA CONTA");
        Console.WriteLine("1 - CONSULTAR SALDO \n2 - REALIZAR SAQUE \n3 - REALIZAR DEPÓSITO \n4 - PAGAR CONTA \n5 - REALIZAR TRANSFÊRENCIA \n6- CONSULTAR SALDO CHEQUE ESPECIAL \n0- ENCERRAR");
        int instrucao = int.Parse(Console.ReadLine());

        if(cont % 5 == 0)
        {
            saldoDevedorChequeEspecial *= 1.1;
        }
        switch (instrucao)
        {
            case 1:
                Console.WriteLine($"SEU SALDO É: {saldo}");
                cont++;

                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 2:
                Console.WriteLine("QUAL VALOR DO SAQUE?");
                double saque = double.Parse(Console.ReadLine());
                cont++;

                if (saldo + limiteChequeEspecial <= saque)
                {
                    Console.WriteLine("SALDO INSUFICIENTE");
                }
                else if (saque <= saldo)
                {
                    saldo -= saque;
                    Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                    cont++;
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
                        saldoDevedorChequeEspecial += saque - saldo;
                        saldo = 0;
                        Console.WriteLine($"SEU SALDO É DE: {saldo}");
                        Console.WriteLine($"SEU LIMITE PARA CHEQUE ESPECIAL ATUAL: {limiteChequeEspecial}");
                    }
                    else
                    {
                        Console.WriteLine("SAQUE NÃO REALIZADO");
                        Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                    }
                }

                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 3:
                cont++;
                Console.WriteLine("QUAL VALOR DO DEPÓSITO?");
                double deposito = double.Parse(Console.ReadLine());
                saldo += deposito;
                Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 4:
                Console.WriteLine("QUAL VALOR DA CONTA QUE DESEJA PAGAR?");
                double valorConta = double.Parse(Console.ReadLine());
                cont++;

                if (saldo + limiteChequeEspecial <= valorConta)
                {
                    Console.WriteLine("SALDO INSUFICIENTE");
                }
                else if (valorConta <= saldo)
                {
                    saldo -= valorConta;
                    Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                }
                else if (saldo + limiteChequeEspecial > valorConta)
                {
                    int respostaUsuarioUtilizarCheque = 0;
                    do
                    {
                        Console.WriteLine($"SEU SALDO DE {saldo} É INSUFICIENTE, DESEJA UTILIZAR {valorConta - saldo} CHEQUE ESPECIAL??");
                        Console.WriteLine("1 - SIM \n2 - NÃO");
                        respostaUsuarioUtilizarCheque = int.Parse(Console.ReadLine());
                    } while (respostaUsuarioUtilizarCheque > 2);

                    if (respostaUsuarioUtilizarCheque == 1)
                    {
                        limiteChequeEspecial = limiteChequeEspecial - (valorConta - saldo);
                        saldo = 0;
                        Console.WriteLine($"SEU SALDO É DE: {saldo}");
                        Console.WriteLine($"SEU LIMITE PARA CHEQUE ESPECIAL ATUAL: {limiteChequeEspecial}");
                    }
                    else
                    {
                        Console.WriteLine("CONTA NÃO PAGA");
                        Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                    }
                }

                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 5:
                Console.WriteLine("QUAL CONTA QUE VOCÊ DESEJA REALIZAR TRANSFERÊNCIA?");
                int numeroConta = int.Parse(Console.ReadLine());
                cont++;

                Console.WriteLine("QUAL VALOR DA TRANSFERÊNCIA?");
                double valorTransferencia = double.Parse(Console.ReadLine());


                if (saldo + limiteChequeEspecial <= valorTransferencia)
                {
                    Console.WriteLine("SALDO INSUFICIENTE");
                }
                else if (valorTransferencia <= saldo)
                {
                    saldo -= valorTransferencia;
                    Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                }
                else if (saldo + limiteChequeEspecial > valorTransferencia)
                {
                    int respostaUsuarioUtilizarCheque = 0;
                    do
                    {
                        Console.WriteLine($"SEU SALDO DE {saldo} É INSUFICIENTE PARA REALIZAR A TRANSFÊRENCIA, DESEJA UTILIZAR {valorTransferencia - saldo} CHEQUE ESPECIAL??");
                        Console.WriteLine("1 - SIM \n2 - NÃO");
                        respostaUsuarioUtilizarCheque = int.Parse(Console.ReadLine());
                    } while (respostaUsuarioUtilizarCheque > 2);

                    if (respostaUsuarioUtilizarCheque == 1)
                    {
                        limiteChequeEspecial = limiteChequeEspecial - (valorTransferencia - saldo);
                        saldo = 0;
                        Console.WriteLine($"SEU SALDO É DE: {saldo}");
                        Console.WriteLine($"SEU LIMITE PARA CHEQUE ESPECIAL ATUAL: {limiteChequeEspecial}");
                    }
                    else
                    {
                        Console.WriteLine("TRANSFÊRENCIA NÃO REALIZADA");
                        Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                    }
                }

                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 6:
                Console.WriteLine($"SALDO DO CHEQUE ESPECIAL: {limiteChequeEspecial}");
                cont++;
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 0:
                Console.WriteLine("VOCÊ REALMENTE DESEJA ENCERRAR?");
                Console.WriteLine("1 - SIM \n2 - NÃO");
                cont++;

                int encerrarSimOuNao = int.Parse(Console.ReadLine());
                if (encerrarSimOuNao == 2)
                {
                    Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                }
                break;
                default:
                 Program.inicializarModulos(Tuple.Create(tipoConta, saldo, limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
        }
    }


    public static void ContaPoupanca(Tuple<int, double, double, int, double> tuplaResultado) {
        int tipoConta = tuplaResultado.Item1;
        double saldo = tuplaResultado.Item2;
        double _limiteChequeEspecial = tuplaResultado.Item3;
        int cont = tuplaResultado.Item4;
        double saldoDevedorChequeEspecial = tuplaResultado.Item5;

        Console.WriteLine($"CONTA POUPANÇA \nSALDO: R$ {saldo} - SALDO POUPANÇA: R$ {_limiteChequeEspecial} - RENDIMENTOS: R${saldoDevedorChequeEspecial}");
        Console.WriteLine("--------------------");

        Console.WriteLine("INFORME O QUE SERÁ REALIZADO NA CONTA");
        Console.WriteLine("1 - CONSULTAR SALDO \n2 - REALIZAR SAQUE \n3 - REALIZAR DEPÓSITO \n4 - PAGAR CONTA \n5 - REALIZAR TRANSFÊRENCIA \n6- CONSULTAR SALDO CHEQUE ESPECIAL \n0- ENCERRAR");
        int instrucao = int.Parse(Console.ReadLine());

        if (cont % 5 == 0)
        {
            saldoDevedorChequeEspecial *= 1.1;
        }
        switch (instrucao)
        {
            case 1:
                Console.WriteLine($"SEU SALDO É: {saldo}");
                cont++;

                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 2:
                Console.WriteLine("QUAL VALOR DO SAQUE?");
                double saque = double.Parse(Console.ReadLine());
                cont++;

                if (saldo + _limiteChequeEspecial <= saque)
                {
                    Console.WriteLine("SALDO INSUFICIENTE");
                }
                else if (saque <= saldo)
                {
                    saldo -= saque;
                    Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                }
                else if (saldo + _limiteChequeEspecial > saque)
                {
                    int respostaUsuarioUtilizarCheque = 0;
                    do
                    {
                        Console.WriteLine($"SEU SALDO DE {saldo} É INSUFICIENTE, DESEJA UTILIZAR {saque - saldo} CHEQUE ESPECIAL??");
                        Console.WriteLine("1 - SIM \n2 - NÃO");
                        saldoDevedorChequeEspecial += saque - saldo;
                        respostaUsuarioUtilizarCheque = int.Parse(Console.ReadLine());
                    } while (respostaUsuarioUtilizarCheque > 2);

                    if (respostaUsuarioUtilizarCheque == 1)
                    {
                        _limiteChequeEspecial = _limiteChequeEspecial - (saque - saldo);
                        saldo = 0;
                        Console.WriteLine($"SEU SALDO É DE: {saldo}");
                        Console.WriteLine($"SEU LIMITE PARA CHEQUE ESPECIAL ATUAL: {_limiteChequeEspecial}");
                    }
                    else
                    {
                        Console.WriteLine("SAQUE NÃO REALIZADO");
                        Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                    }
                }

                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 3:
                cont++;
                Console.WriteLine("QUAL VALOR DO DEPÓSITO?");
                double deposito = double.Parse(Console.ReadLine());
                saldo += deposito;
                Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 4:
                Console.WriteLine("QUAL VALOR DA CONTA QUE DESEJA PAGAR?");
                double valorConta = double.Parse(Console.ReadLine());
                cont++;

                if (saldo + _limiteChequeEspecial <= valorConta)
                {
                    Console.WriteLine("SALDO INSUFICIENTE");
                }
                else if (valorConta <= saldo)
                {
                    saldo -= valorConta;
                    Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                }
                else if (saldo + _limiteChequeEspecial > valorConta)
                {
                    int respostaUsuarioUtilizarCheque = 0;
                    do
                    {
                        Console.WriteLine($"SEU SALDO DE {saldo} É INSUFICIENTE, DESEJA UTILIZAR {valorConta - saldo} CHEQUE ESPECIAL??");
                        Console.WriteLine("1 - SIM \n2 - NÃO");
                        respostaUsuarioUtilizarCheque = int.Parse(Console.ReadLine());
                    } while (respostaUsuarioUtilizarCheque > 2);

                    if (respostaUsuarioUtilizarCheque == 1)
                    {
                        _limiteChequeEspecial = _limiteChequeEspecial - (valorConta - saldo);
                        saldoDevedorChequeEspecial += valorConta - saldo;
                        saldo = 0;
                        Console.WriteLine($"SEU SALDO É DE: {saldo}");
                        Console.WriteLine($"SEU LIMITE PARA CHEQUE ESPECIAL ATUAL: {_limiteChequeEspecial}");
                    }
                    else
                    {
                        Console.WriteLine("CONTA NÃO PAGA");
                        Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                    }
                }

                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 5:
                Console.WriteLine("QUAL CONTA QUE VOCÊ DESEJA REALIZAR TRANSFERÊNCIA?");
                int numeroConta = int.Parse(Console.ReadLine());
                cont++;

                Console.WriteLine("QUAL VALOR DA TRANSFERÊNCIA?");
                double valorTransferencia = double.Parse(Console.ReadLine());


                if (saldo + _limiteChequeEspecial <= valorTransferencia)
                {
                    Console.WriteLine("SALDO INSUFICIENTE");
                }
                else if (valorTransferencia <= saldo)
                {
                    saldo -= valorTransferencia;
                    Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
                }
                else if (saldo + _limiteChequeEspecial > valorTransferencia)
                {
                    int respostaUsuarioUtilizarCheque = 0;
                    do
                    {
                        Console.WriteLine($"SEU SALDO DE {saldo} É INSUFICIENTE PARA REALIZAR A TRANSFÊRENCIA, DESEJA UTILIZAR {valorTransferencia - saldo} CHEQUE ESPECIAL??");
                        Console.WriteLine("1 - SIM \n2 - NÃO");
                        respostaUsuarioUtilizarCheque = int.Parse(Console.ReadLine());
                    } while (respostaUsuarioUtilizarCheque > 2);

                    if (respostaUsuarioUtilizarCheque == 1)
                    {
                        _limiteChequeEspecial = _limiteChequeEspecial - (valorTransferencia - saldo);
                        saldoDevedorChequeEspecial += valorTransferencia - saldo;
                        saldo = 0;
                        Console.WriteLine($"SEU SALDO É DE: {saldo}");
                        Console.WriteLine($"SEU LIMITE PARA CHEQUE ESPECIAL ATUAL: {_limiteChequeEspecial}");
                    }
                    else
                    {
                        Console.WriteLine("TRANSFÊRENCIA NÃO REALIZADA");
                        Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                    }
                }

                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 6:
                Console.WriteLine($"SALDO DO CHEQUE ESPECIAL: {_limiteChequeEspecial}");
                cont++;
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
            case 0:
                Console.WriteLine("VOCÊ REALMENTE DESEJA ENCERRAR?");
                Console.WriteLine("1 - SIM \n2 - NÃO");
                cont++;

                int encerrarSimOuNao = int.Parse(Console.ReadLine());
                if (encerrarSimOuNao == 2)
                {
                    Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                }
                break;
            default:
                Program.inicializarModulos(Tuple.Create(tipoConta, saldo, _limiteChequeEspecial, cont, saldoDevedorChequeEspecial));
                break;
        }
    }
}






