using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Sgs.Business.Model;
using System.Collections.ObjectModel;
using Sgs.Business.Repositories;
using Sgs.Presentation.Mvvm;

namespace Sgs.Presentation.ViewModel
{
    public class EtudiantListViewModel : ViewModelBase
    {
        IEtudiantRepository _repository; 

        private ObservableCollection<Etudiant> _etudiants;

        public EtudiantListViewModel()
        {
            Console.WriteLine("Construtor : Classe EtudiantListViewModel -- Create");

            _repository = App.GetRepositoy();
            _etudiants = new ObservableCollection<Etudiant>(_repository.GetAll()); 
        }

        public ObservableCollection<Etudiant> Etudiants
        {
            get { return _etudiants; }
            set
            {
                _etudiants.Clear();
                _etudiants = value;
            }
        }
    }
}
