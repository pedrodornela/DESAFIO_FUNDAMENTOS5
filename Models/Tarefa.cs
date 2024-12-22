using DESAFIO_FUNDAMENTOS5.Enuns;

namespace DESAFIO_FUNDAMENTOS5.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatus Status { get; set; }
    }
}