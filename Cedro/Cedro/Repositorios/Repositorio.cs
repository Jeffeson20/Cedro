using Cedro.Model;
using Raven.Client;
using Raven.Client.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cedro
{
    public class Repositorio
    {
        public DocumentStore store { get; set; }

        public Repositorio()
        {
            store = new DocumentStore
            {
                Url = "http://localhost:8080",
                DefaultDatabase = "Cedro"
            };
            store.Initialize();
        }

        public String cadastre(Computadores computadores)
        {
            using(IDocumentSession session = store.OpenSession())
            {
                session.Store(computadores);
                session.SaveChanges();
            }
            return computadores.Id;
        }

        public List<Computadores> Liste()
        {
            using (IDocumentSession session = store.OpenSession())
            {
                return session.Query<Computadores>().ToList();
                
            }
            
        }
    }
}
