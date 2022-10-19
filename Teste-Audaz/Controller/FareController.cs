
using Teste_Audaz.Entities;
using Teste_Audaz.Services;

namespace Teste_Audaz.Controller
{
    public class FareController
    {
        private OperatorService _operatorService;
        private FareService FareService;

        public FareController()
        {
            _operatorService = new OperatorService();
        }

        public void CreateFare(Fare fare, string operatorCode)
        {
            var selectedOperator = _operatorService.GetOperatorByCode(operatorCode);
            fare.OperatorId = selectedOperator.Id;

            FareService.Create(fare);
        }
    }
}
