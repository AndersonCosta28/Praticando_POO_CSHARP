class Pessoa
{
    public string nome;
    public int idade;

    public string profissao;

    public Pessoa(string nome, int idade, string profissao)
    {
        this.nome = nome;
        if(idade < 18) {
            this.profissao = "De Menor";
        }
        else
        {
            this.profissao = profissao;
        }
    }

    public void Apresentarse()
    {
        Console.WriteLine("Olá, meu nome é " + nome + " e eu sou " + this.profissao);
    }

    public void Bater()
    {

    }
}