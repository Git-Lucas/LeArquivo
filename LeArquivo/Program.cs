const string caminhoArquivo = "C:\\WorkSpace\\VisualStudio\\LeArquivo\\LeArquivo\\arquivo.txt";

////Leitura do dado completo, retornando uma string com todas as linhas
//var dadoBruto = File.ReadAllText(caminhoArquivo);
//Console.WriteLine(dadoBruto);

////Leitura de dado completo, retornando um array de strings por linha
//var linhas = File.ReadAllLines(caminhoArquivo);
//var linha = 0;
//foreach (var item in linhas)
//{
//    linha++;
//    Console.WriteLine($"Linha {linha} - {item}");
//}

//O "Stream Reader", diferente do "File" - que lê tudo, trazendo para a memória - lê partes de um arquivo
//E o using fechará automaticamente o arquivo quando não estiver mais em uso (Dispose)
using var arquivo = new StreamReader(caminhoArquivo);
string? linha;

while((linha = arquivo.ReadLine()) != null)
{
    Console.WriteLine(linha);
}

arquivo.Close();