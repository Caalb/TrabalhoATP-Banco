namespace TrabalhoATP_Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("QUAL TIPO DE CONTA VOCÊ VAI UTILIZAR?");
                Console.WriteLine("1 - CONTA CORRENTE \n2 - CONTA CORRENTE COM CHEQUE ESPECIAL \n3- CONTA POUPANÇA. ");
                int tipoConta = int.Parse(Console.ReadLine());

                if (tipoConta == 2)
                {
                    Console.WriteLine("LIMITE PARA CHEQUE ESPECIAL");
                }

                Console.WriteLine("QUAL O VALOR DO SALDO INICIAL?");
                double saldo = double.Parse(Console.ReadLine());

                if (tipoConta == 1)
                {
                    Console.WriteLine("INFORME O QUE SERÁ REALIZADO NA CONTA");
                    Console.WriteLine("1 - CONSULTAR SALDO \n2 - REALIZAR SAQUE \n3 - REALIZAR DEPÓSITO \n4 - PAGAR CONTA \n5 - REALIZAR TRANSFÊRENCIA \n6- ENCERRAR");

                    int instrucao = int.Parse(Console.ReadLine());

                    switch (instrucao)
                    {
                        case 1:
                            Console.WriteLine($"SEU SALDO É: {saldo}");
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
                            break;
                        case 3:
                            Console.WriteLine("QUAL VALOR DO DEPÓSITO?");
                            double deposito = double.Parse(Console.ReadLine());
                            saldo += deposito;
                            Console.WriteLine($"SEU SALDO ATUAL É: {saldo}");
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

                            break;
                        case 6:
                            Console.WriteLine("VOCÊ REALMENTE DESEJA ENCERRAR?");
                            Console.WriteLine("1 - SIM \n2 - NÃO");

                            int encerrarSimOuNao = int.Parse(Console.ReadLine());
                            Console.WriteLine(encerrarSimOuNao);

                            break;

                            for (int i = 0; i < numeroConta; i++)
                            {
                                Console.WriteLine(i);
                            }
                            // comentario

                            // caalb comentario
                    }
                }

            }
        }
    }
}