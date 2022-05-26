/*exigencias do projeto
Ao menos 3 classes;
Cada classe precisará ter, ao menos, 2 métodos e 3 atributos significativos para a classe.
Deverá trabalhar a persistência de dados por meio de leitura e/ou escrita de arquivos.
Deverá promover uma integração das classes, por meio de relacionamentos ou listas de objetos.
Deverá fazer uso de estruturas de dados aprendidas como listas, vetores ou matrizes.
Deverá ser criado na linguagem C# utilizando as melhores práticas de orientação a objetos. Os modificadores de acesso devem estar adequados para garantir o encapsulamento dos métodos e atributos.
Deverá ter seu código criado por todos os componentes do grupo ao longo das semanas de construção do software. 
*/

using System;

// Classe para cadastro de cliente com atributos privado
class Cliente
{
    private string nome;
    private char sexo;
    private long cpf;
    private int idade;
    private long telefone;


    // Construtor para obter acesso a classe

    public Cliente(string name, char sex, long num_cpf, int age, long tel)
    {

        nome = name;
        sexo = sex;
        cpf = num_cpf;
        idade = age;
        telefone = tel;


    }

}

class Program
{
    public static void Main(string[] args)
    {

        Cliente c1 = new Cliente(" Marcos", 'M', 15214785975, 28, 32287458);
        Cliente c2 = new Cliente(" Marcos", 'F', 15214785975, 28, 32287458);

        System.Console.WriteLine(c1);

    }
}