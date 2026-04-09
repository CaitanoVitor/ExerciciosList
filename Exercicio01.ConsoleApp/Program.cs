Console.WriteLine("Digite o COMPRIMENTO da caixa RETANGULAR: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o LARGURA da caixa RETANGULAR: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o ALTURA da caixa RETANGULAR: ");
double altura = Convert.ToDouble(Console.ReadLine());

double volume = comprimento * largura * altura;

Console.WriteLine($"O Volume da CAIXA é: {volume:F2} cm³");

Console.ReadLine();
