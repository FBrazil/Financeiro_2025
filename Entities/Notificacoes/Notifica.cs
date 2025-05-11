using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notificacoes;

public class Notifica
{
    [NotMapped]
    public string NomePropriedade { get; set; }
    [NotMapped]
    public string Mensagem { get; set; }
    [NotMapped]
    public List<Notifica> Notificacoes { get; set; } = new List<Notifica>();

    public bool ValidaPropriedadeString(string valor , string nomePropriedade)
    {
        if (string.IsNullOrEmpty(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
        {
            Notificacoes.Add(new Notifica
            {
                Mensagem = "Campo Obrigatório",
                NomePropriedade = nomePropriedade
            });
            return false;
        }
        return true;
    }

    public bool ValidaPropriedadeInt(int valor, string nomePropriedade)
    {
        if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
        {
            Notificacoes.Add(new Notifica
            {
                Mensagem = "Campo Obrigatório",
                NomePropriedade = nomePropriedade
            });
            return false;
        }
        return true;
    }
}
