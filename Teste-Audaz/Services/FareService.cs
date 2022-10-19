using Teste_Audaz.Entities;
using Teste_Audaz.Repository;

namespace Teste_Audaz.Services
{
    public class FareService
    {
        private BaseRepository _repository = new BaseRepository();

        public void Create(Fare fare)
        {
            _repository.Insert(fare);
        }

        public void Update(Fare fare)
        {
            _repository.Update(fare);
        }

        public Fare GetFareById(Guid fareId)
        {
            var fare = _repository.GetById<Fare>(fareId);
            return fare;
        }

        public List<Fare> GetFares()
        {
            var fares = _repository.GetAll<Fare>();
            return fares;
        }
    }
}
