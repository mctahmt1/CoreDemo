using DataAccessLayer.Abstract;
using DataAccessLayer.Contcrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfBlogRepository : GenericRepository<CitiesAddViewModel>, IBlogDal
	{
		public List<CitiesAddViewModel> GetListWithCategory()
		{
			using (var c = new Context())
				return c.Blogs.Include(x => x.Category).ToList();
		}
	}
}
