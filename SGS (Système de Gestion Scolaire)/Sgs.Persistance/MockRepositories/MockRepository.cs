using Sgs.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sgs.Business.Model;

namespace Sgs.Persistance.MockRepositories
{
    public class MockRepository : IRepository
    {
        List<Etudiant> _etudiants;
        Dictionary<string, Etudiant> _tmpList;

        public MockRepository()
        {
            Console.WriteLine("Construtor : Classe MockRepository -- Create");

            _etudiants = new List<Etudiant>();

            _etudiants.Add(new Etudiant(1, "Newton Mock", "Isac", "Gravity street", "25", "1042", "London"));
            _etudiants.Add(new Etudiant(2, "Holmes Mock", "Holmes", "Baker street", "121b", "1000", "London"));
            _etudiants.Add(new Etudiant(3, "Babbage Mock", "Charles", "Analytical street", "26", "1019", "Oxford"));
            _etudiants.Add(new Etudiant(4, "Lovelace Mock", "Ada", "Argorithm street", "20", "1015", "Oxford"));

            foreach (Etudiant etudiant in _etudiants)
                Console.WriteLine("  --> {0}", etudiant);

        }

        List<Etudiant> IEtudiantRepository.GetAll()
        {
            return _etudiants;
        }

        Etudiant IEtudiantRepository.GetById(int id)
        {
            foreach(Etudiant etudiant in _etudiants)
            {
                if (etudiant.Id == id)
                    return etudiant;
            }

            // à gerer avec un NullObject!
            return null;
        }

        void IEtudiantRepository.Save()
        {
            foreach(KeyValuePair<string, Etudiant> pair in _tmpList)
            {
                if (pair.Key == "Insert")
                    _etudiants.Add(pair.Value);

                if (pair.Key == "Delete")
                    _etudiants.Remove(pair.Value);

                //-- Update -- do nothing
            }

            _tmpList.Clear();
        }

        void IEtudiantRepository.Insert(Etudiant etudiant)
        {
            _tmpList.Add("Insert", etudiant);
        }

        void IEtudiantRepository.Delette(Etudiant etudiant)
        {
            _tmpList.Add("Delete", etudiant);
        }

        void IEtudiantRepository.Update(Etudiant etudiant)
        {
            _tmpList.Add("Update", etudiant);
        }
    }
}
