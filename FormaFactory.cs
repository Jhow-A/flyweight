using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    // FlyweightFactory
    public static class FormaFactory
    {
        private const string Circulo = nameof(Circulo);

        private static readonly Dictionary<string, IForma> formas = new Dictionary<string, IForma>();

        public static IForma GetForma(string chave)
        {
            IForma forma;

            if (formas.ContainsKey(chave))
                return formas[chave];
            else
            {
                if (chave.Equals(Circulo))
                {
                    forma = new Circulo();
                    formas.Add(Circulo, forma);
                }
                else
                    throw new Exception("Este tipo de objeto não pode ser criado");
            }
            return forma;
        }
    }
}
