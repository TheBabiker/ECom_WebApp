using BookShop.DataAccess.Data;
using BookShop.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _db;
        public ICategoryRepository CategoryR{ get; private set; }
        public UnitOfWork(ApplicationDBContext db)
        {
            _db = db;
            CategoryR = new CategoryRepository(_db);
        }
       

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
