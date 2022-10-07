using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoATP_Banco.Modulos
{
    public class InicializacaoSistema
    {
        public static Tuple<int, double> start()
        {
            Console.WriteLine("QUAL TIPO DE CONTA VOCÊ VAI UTILIZAR?");
            Console.WriteLine("1 - CONTA CORRENTE \n2 - CONTA CORRENTE COM CHEQUE ESPECIAL \n3 - CONTA POUPANÇA. ");
            int tipoConta = int.Parse(Console.ReadLine());
            if (tipoConta == 2)
            {
                Console.WriteLine("LIMITE PARA CHEQUE ESPECIAL");
            }

            Console.WriteLine("QUAL O VALOR DO SALDO INICIAL?");
            double saldo = double.Parse(Console.ReadLine());
            return Tuple.Create(tipoConta, saldo);
        }
    }
    public class ContaCorrente
    {


    }



}
