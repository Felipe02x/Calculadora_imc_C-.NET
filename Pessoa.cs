using System;

class Pessoa
{
    // cria os atributos
    public double peso, altura;

    // cria os métodos
    public double calculo()
    {
        return peso / (altura * altura);
    }

    public string situacao(double imc)
    {
        // Variável de retorno
        string retorno;

        //condicional
        if (imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if (imc < 25)
        {
            retorno = "Peso normal";
        }
        else if (imc < 30)
        {
            retorno = "Acima do peso";
        }
        else if (imc < 35)
        {
            retorno = "Obesidade I";
        }
        else if (imc < 40)
        {
            retorno = "Obesidade II";
        }
        else
        {
            retorno = "Obesidade III";
        }
        return retorno;
    }

    public void Mensagem()
    {
        double obtercalculo = calculo();

        // obter situacao
        string obterSituacao = situacao(obtercalculo);

        // exibir mensagem
        Console.WriteLine("Seu imc é de " + obtercalculo);
        Console.WriteLine("Sua situação é de: "+situacao);
    }
}


