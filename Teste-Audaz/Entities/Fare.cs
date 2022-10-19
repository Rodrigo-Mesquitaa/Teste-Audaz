using Teste_Audaz.Interfaces;

namespace Teste_Audaz.Entities
{
    public class Fare : IModel
    {
        public Guid Id { get; set; }
        public Guid OperatorId { get; set; }
        public int Status { get; set; }
        public decimal Value { get; set; }
    }
}
