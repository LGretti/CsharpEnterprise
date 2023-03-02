
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

}

void exercicio3() {

}