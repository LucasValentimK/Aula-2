using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoSoma.Modelo
{
    public class Controle
    {
        public Controle()
        {
        }

        public String Calcular(String num1, String num2, String op)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            String resposta = "";
            try
            {
                n1 = Convert.ToDouble(num1);
                n2 = Convert.ToDouble(num2);
                if (op.Equals("+"))
                    resultado = n1 + n2;
                if (op.Equals("-"))
                    resultado = n1 - n2;
                if (op.Equals("*"))
                    resultado = n1 * n2;
                resposta = ("Seu resultado é:") + resultado.ToString();
                if (op.Equals("/"))
                    if (n2 == 0)
                        resposta = "Não é possivel a divisão por zero";
                    else
                    {
                        resultado = n1 / n2;
                        resposta = ("Seu resultado é:") + resultado.ToString();
                    }
            }
            catch (FormatException e)
            {
                resposta = "Escreva um número correto";
            }
            return resposta;
        }
    }
}
