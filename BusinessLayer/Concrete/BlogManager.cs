using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void BlogAdd(CitiesAddViewModel blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(CitiesAddViewModel blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(CitiesAddViewModel blog)
		{
			throw new NotImplementedException();
		}

		public List<CitiesAddViewModel> GetBlogListWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}

		public CitiesAddViewModel GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<CitiesAddViewModel> GetBlogById(int id)
		{
			return _blogDal.GetListAll(x=> x.BlogID == id);
		}

		public List<CitiesAddViewModel> GetList()
		{
			return _blogDal.GetListAll();
		}

		public List<CitiesAddViewModel> GetBlogListByWriter(int id)
		{
			return _blogDal.GetListAll(x=>x.WriterID == id);
		}
	}
}
