using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.BusinessLayer.Abstract;
using Topic.DataAccessLayer.Abstract;
using Topic.EntityLayer.Entities;

namespace Topic.BusinessLayer.Concrete
{
	public class FaqManager : GenericManager<FAQ>, IFaqService
	{
		public FaqManager(IGenericDal<FAQ> genericDal) : base(genericDal)
		{
		}
	}
}
