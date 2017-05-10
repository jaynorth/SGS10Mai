using Sgs.Business.Repositories;
using Sgs.Persistance.MockRepositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Sgs.Presentation
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IRepository _repository;

        public App()
        {
            Console.WriteLine("Bienvenu à SGS (Système de Gestion Scolaire) \n \n");
        }

        public static IRepository GetRepositoy()
        {
            if(_repository == null)
                _repository = new MockRepository();

            return _repository;
        }
    }
}
