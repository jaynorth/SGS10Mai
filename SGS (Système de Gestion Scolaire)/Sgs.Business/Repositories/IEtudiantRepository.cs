using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sgs.Business.Model;

namespace Sgs.Business.Repositories
{
    public interface IEtudiantRepository
    {
        List<Etudiant> GetAll();
        Etudiant GetById(int id);
        void Insert(Etudiant etudiant);
        void Update(Etudiant etudiant);
        void Delette(Etudiant etudiant);
        void Save();
    }
}
