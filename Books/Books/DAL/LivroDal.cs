using Books.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL
{
    public class LivroDal : IDisposable
    {
        private BookContext contexto;

        public LivroDal()
        {
            this.contexto = new BookContext();
        }

        public void Excluir( Livro l )
        {
            contexto.TB_LIVROS.Remove(l);
            contexto.SaveChanges();
        }
        public void Salvar(Livro l)
        {
            contexto.TB_LIVROS.Add(l);
            contexto.SaveChanges();
        }
        public IList<Livro> Preencher()
        {
            return contexto.TB_LIVROS.ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
