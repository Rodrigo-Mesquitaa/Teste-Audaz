using Teste_Audaz.Entities;
using Teste_Audaz.Repository;

namespace Teste_Audaz.Services
{
    public class OperatorService
    {

        public BaseRepository _repository = new BaseRepository();

        public Operator GetOperatorByCode(string code)
        {
            var operators = _repository.GetAll<Operator>();
            var selectedOperator = operators.FirstOrDefault(o => o.Code == code);
            return selectedOperator;
        }

        public Operator GetOperatorById(Guid id)
        {
            var selectedOperator = _repository.GetById<Operator>(id);
            return selectedOperator;
        }

        public List<Operator> GetOperators()
        {
            var operators = _repository.GetAll<Operator>();
            return operators;
        }

        public void Create(Operator insertingOperator)
        {
            _repository.Insert(insertingOperator);
        }

        public void Update(Operator updatingOperator)
        {
            _repository.Update(updatingOperator);
        }
    }
}