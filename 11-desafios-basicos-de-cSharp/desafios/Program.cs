
string op = Console.ReadLine();

switch (op) {
    case "1":
        exercicio1();
        break;
    case "2":
        exercicio2();
        break;
    case "3":
        exercicio3();
        break;
    default:
        break;
}

void exercicio1() {
    int a, b;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("PROD = " + (a * b)); //implemente o código que representa a multiplicação.
    Console.ReadLine();
};

void exercicio2() {
    int x = int.Parse(Console.ReadLine());
    string[] n = Console.ReadLine().Split(' ');

    int multiplo2 = 0;
    int multiplo3 = 0;
    int multiplo4 = 0;
    int multiplo5 = 0;

    for (int i = 0; i < x; i++) {
        if ((int.Parse(n[i]) % 2) == 0) multiplo2++;

        if ((int.Parse(n[i]) % 3) == 0) multiplo3++;

        if ((int.Parse(n[i]) % 4) == 0) multiplo4++;

        if ((int.Parse(n[i]) % 5) == 0) multiplo5++;
    }

    Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
    Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
    Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
    Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);
}

void exercicio3() {
    double pi, raio, volume;
    pi = 3.14159;
 
    raio = double.Parse(Console.ReadLine());
    volume = 4.0 * pi * Math.Pow(raio, 3) / 3;

    Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
}