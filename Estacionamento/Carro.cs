using System;
using System.Collections.Generic;

class Carro
{
    public string Placa { get; set; }
    public DateTime HoraEntrada { get; set; }

    public Carro(string placa)
    {
        Placa = placa;
        HoraEntrada = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Carro - Placa: {Placa}, Entrada: {HoraEntrada:HH:mm:ss}";
    }
}