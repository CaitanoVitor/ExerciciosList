Console.WriteLine("Qual é o KM até o inicial do veiculo: ");
double kmInicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual é o KM até o Final do veiculo: ");
double kmFinal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o consumo do combustivel em Litros após a viagem: ");
double consumoCombustivel = Convert.ToDouble(Console.ReadLine());


double distanciaPercorrida = kmFinal - kmInicial;

double consumoKm = distanciaPercorrida / consumoCombustivel;

Console.WriteLine($"O consumo do combustivel durante a viagem foi de ~ {consumoKm:F2} KM/L");

Console.ReadLine();