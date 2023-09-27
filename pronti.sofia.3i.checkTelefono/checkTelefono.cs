using System;
using System.Collections.Generic;

public static class Telefono
{
    public static string Check(string[] input)
    {
        for(int i=0 ; i < input.Length ; i++)
            foreach (char c in input[i])
            if(!char.IsDigit(c) && c != '+')
            input[i] = "Non Valido";


        foreach (string numero in input)
        {
            if ((numero.StartsWith("+39") && numero.Length == 13) ||
                (numero.StartsWith("0039") && numero.Length == 14) ||
                (numero.StartsWith("3") && numero.Length == 10))
            {
                return numero;
            }
        }
        return "";
    }
}