
using redimensionador_de_imagens.Services;
namespace redimensionador_de_imagens;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Cole abaixoo caminho da pasta onde estão suas imagens: ");
        var path = Console.ReadLine();
        Redimensionador redimensionador = new Redimensionador();

        redimensionador.Redimensionar(path);
    }
}

