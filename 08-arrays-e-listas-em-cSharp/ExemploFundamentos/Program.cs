﻿using ExemploFundamentos.Common.Models;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
//arrayInteiros[3] = 1;

for (int i = 0; i < arrayInteiros.Length; i++) {
    Console.WriteLine($"Posição n{i} - {arrayInteiros[i]}");
}