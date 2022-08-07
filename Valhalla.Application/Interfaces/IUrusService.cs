using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Application.Requests;
using Valhalla.Domain.Entities;

namespace Valhalla.Application.Interfaces
{
    public interface IUrusService
    {
        IEnumerable<Urus> GetUrus();
        Urus GetUrus(string id);
        void AddUrus(CreateUrusRequest urus);
        void UpdateUrus(UpdateUrusRequest urus);
        void DeleteUrus(string id);
    }
}
