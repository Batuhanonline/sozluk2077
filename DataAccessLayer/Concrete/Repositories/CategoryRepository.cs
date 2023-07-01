using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        //Context context = new Context();
        //DbSet<Category> _object;
        //void ICategoryDal.AddCategory(Category category)
        //{
        //    _object.Add(category);
        //    context.SaveChanges();
        //}

        //void ICategoryDal.DeleteCategory(Category category)
        //{
        //    _object.Remove(category);
        //    context.SaveChanges();
        //}

        //List<Category> ICategoryDal.GetCategories()
        //{
        //    return _object.ToList();
        //}

        //void ICategoryDal.UpdateCategory(Category category)
        //{
        //    context.SaveChanges();
        //}
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetAll(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetFind(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
