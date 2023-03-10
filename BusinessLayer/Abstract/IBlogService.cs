using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(CitiesAddViewModel blog);
		void BlogDelete(CitiesAddViewModel blog);
		void BlogUpdate(CitiesAddViewModel blog);
		List<CitiesAddViewModel> GetList();
		CitiesAddViewModel GetById(int id);
		List<CitiesAddViewModel> GetBlogListWithCategory();
		List<CitiesAddViewModel> GetBlogListByWriter(int id);
	}
}
