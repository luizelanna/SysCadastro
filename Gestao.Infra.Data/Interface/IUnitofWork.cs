using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Infra.Data.Interface
{
    public interface IUnitofWork
    {
        void Commit();
    }
}
