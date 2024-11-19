

string diretorioInicial = @"C:\Estados";
ListarDiretorios(diretorioInicial);

Console.WriteLine("FIM");

//funções
void ListarDiretorios (string caminhoInicial)
{
    Console.WriteLine($"Diretório : {caminhoInicial}");

    string[] subdiretorios = Directory.GetDirectories(caminhoInicial);

    foreach (var subdiretorioAtual in subdiretorios)
    {
        ListarDiretorios(subdiretorioAtual);
    }

}
