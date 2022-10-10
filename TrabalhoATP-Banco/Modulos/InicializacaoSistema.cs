using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoATP_Banco.Modulos
{
    public class InicializacaoSistema
    {
        public static Tuple<int, double, double> start()
        {
            int tipoConta;
            do
            {
                Console.WriteLine("QUAL TIPO DE CONTA VOCÊ VAI UTILIZAR?");
                Console.WriteLine("1 - CONTA CORRENTE \n2 - CONTA CORRENTE COM CHEQUE ESPECIAL \n3 - CONTA POUPANÇA. ");
                tipoConta = int.Parse(Console.ReadLine());
            } while (tipoConta > 3);

            Console.WriteLine("QUAL O VALOR DO SALDO INICIAL?");
            double saldo = double.Parse(Console.ReadLine());

            double limiteChequeEspecial = 0;
            if(tipoConta == 2)
            {
                Console.WriteLine("QUAL LIMITE PARA CHEQUE ESPECIAL? ");
                limiteChequeEspecial = double.Parse(Console.ReadLine());
            }


            
            return Tuple.Create(tipoConta, saldo, limiteChequeEspecial);
        }
    }
}
