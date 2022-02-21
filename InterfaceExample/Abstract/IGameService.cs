using InterfaceExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Abstract
{
    public interface IGameService
    {
        void Add(Games game);
        void Update(Games game);
        void Delete(Games game);
    }
}
