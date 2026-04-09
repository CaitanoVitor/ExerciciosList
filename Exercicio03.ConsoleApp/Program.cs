decimal temperaturaCelsius, temperaturaFahrenheit;

Console.WriteLine("Digite a temperatura em graus Celsius: ");
temperaturaCelsius = Convert.ToDecimal(Console.ReadLine());

temperaturaCelsius = (temperaturaCelsius * 9 /5) + 32;

Console.WriteLine("A temperetura em Fahrenheit é: " + temperaturaCelsius);

Console.ReadLine();