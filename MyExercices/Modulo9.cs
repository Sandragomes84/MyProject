using System.Linq;


namespace MyExercices;

public static class Modulo9
{
    //Exercício 1

    public static void ReadName()
    {
        Console.WriteLine("Escreva o seu nome, por favor!");
        string name = Console.ReadLine();

        Console.WriteLine(name);

    }


    //Exercício 2

    public static void ReadFirsAndLast()
    {
        Console.WriteLine("Escreva o seu nome completo, por favor!");
        string nomeCompleto = Console.ReadLine();
              
        var nome = nomeCompleto.Split(" ")[0];
        var qtdnome = nomeCompleto.Split(" ").Length;
        var sobrenome = nomeCompleto.Split(" ")[qtdnome - 1];
       
        Console.WriteLine(nome + " " + sobrenome);
        Console.Read();

    }


    //Exercício 3

    public static void ConcatString()
    {
        string nome, apelidos;

        Console.WriteLine("Escreva o seu primeiro nome!");
        nome = Console.ReadLine().Trim();
        nome = nome.Trim();
        Console.WriteLine("Escreva os seus apelidos!");
        apelidos = Console.ReadLine().Trim(); ;

        apelidos = apelidos.Replace(" ", "");
                
        Console.WriteLine(nome+apelidos);
        
         
    }

    //Exercicio 4 - Escrever e testar um programa que peça o nome completo e converta para maiúsculas o 1º, 3º e 5º nome.


    public static void FullName()
    {
        Console.WriteLine(" Digite o seu nome completo: ");
        string [] fullName = (Console.ReadLine().Split(' '));

        var str0 = fullName[0].ToUpper();
        var str2 = fullName[2].ToUpper();
        var str4 = fullName[4].ToUpper();



        if (fullName.Length == 0 || fullName.Length == 1)
        {
            Console.WriteLine(str0);
        }
        else if (fullName.Length == 2 || fullName.Length == 3)
        {
            Console.WriteLine(str0 + " " + str2);
        }
        else
        {
            Console.WriteLine(str0 + " " + str2 + " " + str4);
        }

        Console.Read();
    }


   //Exercício 5

    public static void FirstIndex()
    {
        Console.WriteLine("Por favor, insira uma palavra:");
        string word = Console.ReadLine();

        var str = word.Substring(0, 1);
        
        Console.WriteLine(str);

    }
        
    //Exercício 6
    
    public static void HowMany()
    {
        Console.WriteLine("Por favor, insira uma palavra:");
        string [] word = Console.ReadLine().Split();
        Console.WriteLine("Digite apenas o caracter que pretende contar:");
        string c = (Console.ReadLine());


        
        int count = 0;


        for (int i = 0; i < word.Length; i++)
        {

            if (word[i] == c)
            {
                count = count + 1;

            }


        }
            
            
        Console.WriteLine($"O caracter [{c}], repete-se {count} vezes!");
        



        Console.Read();

    }
       


             





    




}
