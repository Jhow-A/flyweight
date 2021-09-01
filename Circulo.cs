using System;

namespace FlyweightPattern
{
    // Concrete Flyweight
    public class Circulo : IForma
    {
        // Estado extrínseco
        public string Cor { get; set; }

        // Estado intrínseco (cache)
        private readonly int x = 10;
        private readonly int y = 20;
        private readonly int raio = 30;

        public void SetCor(string Cor)
        {
            this.Cor = Cor;
        }

        public void Desenhar() =>
            Console.WriteLine($"Desenhando círculo - [cor:{Cor}, x:{x}, y:{y}, raio:{raio}]");
    }
}
