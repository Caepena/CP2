﻿using CP2.Domain.Entity;
using CP2.Domain.Enums;
using System.Text.Json.Serialization;

public class Moto
{
    public Guid Id { get; private set; }
    public string Modelo { get; private set; }
    public string Marca { get; private set; }
    public string Cor { get; private set; }
    public string Placa { get; private set; }
    public StatusMoto StatusMoto { get; private set; }

    public Guid IdGaragem { get; set; }

    public Moto(string modelo, string marca, string cor, string placa, StatusMoto statusMoto, Guid idGaragem)
    {
        Modelo = modelo;
        Marca = marca;
        Cor = cor;
        Placa = placa;
        StatusMoto = statusMoto;
        IdGaragem = idGaragem;
    }
}