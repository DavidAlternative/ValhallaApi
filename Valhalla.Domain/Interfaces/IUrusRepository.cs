using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Domain.Entities;

namespace Valhalla.Domain.Interfaces
{
    public interface IUrusRepository
    {
        IEnumerable<Urus> GetUrus();
        Urus GetUrus(string id);
        void AddUrus(Urus urus);
        void UpdateUrus(Urus urus);
        void RemoveUrus(string id);
    }
}
