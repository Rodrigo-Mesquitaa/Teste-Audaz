using Teste_Audaz.Interfaces;

namespace Teste_Audaz.Entities
{
    public class Operator : IModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }

    }
}
