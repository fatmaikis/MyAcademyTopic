﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.DTOLayer.DTOs.FaqDtos
{
    public class UpdateFaqDto
    {
		public int FAQID { get; set; }
		public string Question { get; set; }
		public string Answer { get; set; }
	}
}
