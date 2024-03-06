namespace ATV2_CJ3022048
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            int resp;

            Console.WriteLine("Exercicio 1");
            Console.WriteLine("digite um valor em metros: ");
            n = int.Parse(Console.ReadLine());
            resp = n * 100;
            Console.WriteLine("o resultado em centímetros é: {0}", resp);



            Console.WriteLine("Exercicio 2");
            int f;
            int c;

            Console.WriteLine("digite um  valor  em  graus  Fahrenheit: ");
            f = int.Parse(Console.ReadLine());
            c = (f - 32) * (5 / 9);
            Console.WriteLine("o resultado em graus celsuis é= {0}", c);
            // o sistema não conta números reais 

            float fa, ce;

            Console.WriteLine("digite um  valor  em  graus  Fahrenheit: ");
            fa = float.Parse(Console.ReadLine());
            ce = (fa - 32f) * (5f / 9f);
            Console.WriteLine("o resultado em graus celsuis é= {0}", ce);


            Console.WriteLine("exercicio 3");

            float alt, peso, imc;
            Console.WriteLine("digite seu peso: ");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("digite sua altura: ");
            alt = float.Parse(Console.ReadLine());
            imc = peso / (alt * alt);
            Console.WriteLine("sua massa corporal é: {0}", imc);


            Console.WriteLine("EXERCICIO 4");

            int n1, n2, n3, med;
            Console.WriteLine("digite um valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite um valor: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite um valor: ");
            n3 = int.Parse(Console.ReadLine());
            med = (n1 + n2 + n3) / 3;
            Console.WriteLine("a média é: {0}", med);


            Console.WriteLine("exercicio 5");

            int vo, v, a, t;
            Console.WriteLine("vamos calcular a velocidade de algo?");
            Console.WriteLine(" diga a velocidade inicial: ");
            vo = int.Parse(Console.ReadLine());
            Console.WriteLine("diga a aceleração: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("diga o tempo: ");
            t = int.Parse(Console.ReadLine());
            v = vo / (a * t);
            Console.WriteLine("a velocidade é: {0}", v);


            Console.WriteLine("exercicio 6");

            int salario, novosalario, aumento;

            Console.WriteLine("Qual é o seu salário atual? ");
            salario = int.Parse(Console.ReadLine());

            aumento = (25 / 100) * salario;
            novosalario = salario + aumento;

            Console.WriteLine("Novo salário: {0} ", novosalario);


            Console.WriteLine("exercicio 7");

            float real, dolar, cot;

            Console.WriteLine("Digite um valor em reais: ");
            real = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cotação do dólar: ");
            cot = float.Parse(Console.ReadLine());

            dolar = real / cot;

            Console.WriteLine("Esse valor em reais, equivale a {0} dólares.", dolar);


            Console.WriteLine("exercicio 8");


            int n, ant, suce, soma;

            Console.WriteLine("Escreva um número: ");
            n = int.Parse(Console.ReadLine());

            ant = (n * 2) - 1;
            suce = (n * 3) + 1;
            soma = ant + suce;

            Console.WriteLine("Soma: {0} ", soma);


            Console.WriteLine("exercicio 9");

            int valor, milhar, milhar1, centena, centena1, dezena, dezena1, unidade, valor1, valor2;

            Console.WriteLine("Escreva um número: ");
            valor = int.Parse(Console.ReadLine());
            milhar = valor / 1000;
            milhar1 = milhar * 1000;
            centena = (valor - milhar) / 100;
            centena1 = centena * 100;
            valor1 = milhar1 + centena1;
            dezena = (valor - valor1) / 10;
            dezena1 = dezena * 10;
            valor2 = milhar1 + centena1 + dezena1;
            unidade = valor - valor2;

            Console.WriteLine("{0{\n{1}\n{2}\n{3}", milhar, centena, dezena, unidade);


            Console.WriteLine("exercicio 10");

            float valor01 = 1000;
            float valor_dia01 = -3.4f;
            float valor_dia02 = 2.8f;
            float valor_dia03 = 14f;
            float valor_dia04 = -8.5f;

            float dia01 = valor01 * (1 + valor_dia01 / 100);
            float dia02 = dia01 * (1 + valor_dia02 / 100);
            float dia03 = dia02 * (1 + valor_dia03 / 100);
            float dia04 = dia03 * (valor_dia04 / 100);

            Console.WriteLine(" O valor atual dos investimentos de Marquesito é R$ {0}", dia04);


            Console.WriteLine("exercicio 11");

            int n, n2, n3;

            Console.WriteLine("Digite um número inteiro:");
            n = int.Parse(Console.ReadLine());

            n2 = n * n;
            n3 = n * n * n;

            Console.WriteLine("Esse número ao quadrado é igual a {0} e esse número ao cubo é igual a {1}", n2, n3);


            Console.WriteLine("exercicio 12");

            float h, p_h, p_m;

            Console.WriteLine("Digite o valor da sua altura: ");
            h = float.Parse(Console.ReadLine());

            p_h = (72.7f * h) - 58f;
            p_m = (62.1f * h) - 44.7f;

            Console.WriteLine(" Seu peso ideal é \nPeso ideal para homens com essa altura: {0} \nPeso ideal para mulheres com essa altura: {1}", p_h, p_m);


            Console.WriteLine("exercicio 13");
            Console.WriteLine("Git: é um sistema de controle de versão distribuído, projetado para lidar com qualquer projeto, desde pequenos até grandes, com rapidez e eficiência. Ele permite que múltiplos desenvolvedores trabalhem simultaneamente em um mesmo projeto, controlando as mudanças e facilitando a colaboração.\r\n\r\nGitHub: é uma plataforma de hospedagem de código-fonte que utiliza o Git como sistema de controle de versão. Ele oferece recursos adicionais como controle de acesso, gerenciamento de problemas, rastreamento de bugs, integração contínua e muito mais. O GitHub é amplamente utilizado por desenvolvedores para compartilhar e colaborar em projetos de código aberto e privados.");
            Console.WriteLine("git init: Inicializa um repositório Git em um diretório específico.\r\ngit clone [url]: Clona um repositório Git existente para o seu computador.\r\ngit add [arquivo]: Adiciona um arquivo ou uma mudança específica ao índice (staging area) para ser preparado para o próximo commit.\r\ngit commit -m \"mensagem\": Realiza um commit com as mudanças no índice, acompanhado de uma mensagem que descreve as alterações feitas.\r\ngit status: Exibe o estado atual do repositório, mostrando arquivos modificados, adicionados ou removidos.\r\ngit push: Envia as alterações locais para um repositório remoto.\r\ngit pull: Puxa as alterações de um repositório remoto para o repositório local.\r\ngit branch: Lista todas as branches disponíveis no repositório.\r\ngit checkout [branch]: Altera a branch de trabalho atual para a especificada.\r\ngit merge [branch]: Combina os commits de outra branch na branch atual.");



        }
    }
}



