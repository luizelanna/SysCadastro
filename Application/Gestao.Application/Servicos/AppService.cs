using Gestao.Infra.Data.Interface;

namespace Gestao.Application.Servicos
{
    public class AppService
    {
        public readonly IUnitofWork _uow;

        public AppService(IUnitofWork uow)
        {
            _uow = uow;
        }

        public void Commit()
        {
            _uow.Commit();
        }

    }
}