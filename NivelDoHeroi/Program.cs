Console.WriteLine("Informe o nome do Heroi");
string nome = Console.ReadLine();

Console.WriteLine("Informe a quantidade de experiëncia");
int experiencia = Convert.ToInt32(Console.ReadLine());

string nivel = "";

switch (experiencia)
{
    case <= 1000:
        nivel = "Ferro";
        break;

    case <= 2000:
        nivel = "Bronze";
        break;

    case <= 5000:
        nivel = "Prata";
        break;

    case <= 7000:
        nivel = "Ouro";
        break;

    case <= 8000:
        nivel = "Platina";
        break;

    case <= 9000:
        nivel = "Ascendente";
        break;

    case <= 10000:
        nivel = "Imortal";
        break;

    case > 10000:
        nivel = "Radiante";
        break;
}

Console.WriteLine($"O Herói de nome {nome} está no nível de {nivel}");