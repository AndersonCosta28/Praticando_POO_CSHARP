using System;
internal class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Rodrigo", 10, "Programador");

        Pessoa p2 = new Pessoa("TT", 20, "Médico");

        Pessoa p3 = new ("Nelson", 30, "Técnico de impressora");

        Pessoa[] pessoas = {p1,p2,p3};        

        for (int i = 0; i < pessoas.Length; i++){
            pessoas[i].Apresentarse();
        }
    }
}
