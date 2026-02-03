using CakeFactory.Data;
using System;
using System.Collections.Generic;
using System.Linq;

// Datos de ejemplo para las consultas
var listaFrutas = new List<Fruta> {
    new Fruta { Nombre = "Mango", PaisDeOrigen = "Mexico" },
    new Fruta { Nombre = "Mora", PaisDeOrigen = "Noruega" },
    new Fruta { Nombre = "Fresa", PaisDeOrigen = "Noruega" }
};

var listaPostres = new List<Postre> {
    new Postre { Nombre = "Gelatina", PaisDeOrigen = "Ecuador" },
    new Postre { Nombre = "Mousse", PaisDeOrigen = "Colombia", Frutas = new List<Fruta> { listaFrutas[0] } }
};

// Consultas de la pizarra
Console.WriteLine("--- Frutas de Noruega ---");
var noruega = listaFrutas.Where(f => f.PaisDeOrigen == "Noruega");
foreach(var f in noruega) Console.WriteLine($"- {f.Nombre}");

Console.WriteLine("\n--- Postres con Mango ---");
var conMango = listaPostres.Where(p => p.Frutas.Any(f => f.Nombre == "Mango"));
foreach(var p in conMango) Console.WriteLine($"- {p.Nombre}");

Console.WriteLine("\n--- Postres de Ecuador ---");
var ecuador = listaPostres.Where(p => p.PaisDeOrigen == "Ecuador");
foreach(var p in ecuador) Console.WriteLine($"- {p.Nombre}");