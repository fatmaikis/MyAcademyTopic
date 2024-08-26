using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.DTOLayer.DTOs.CategoryDtos;

namespace Topic.DTOLayer.DTOs.FaqDtos
{
    public class ResultFaqDto
    {
		public int FAQID { get; set; }
		public string Question { get; set; }
		public string Answer { get; set; }
	}
}
