using System.Text.Json.Serialization;

namespace Projetomecanica.api.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TimeOnly Hora { get; set; }
        public string Seviço { get; set; }

        public int VeiculoId { get; set; }
        [JsonIgnore]
        public Veiculo? Veiculo { get; set; }

    }
}
