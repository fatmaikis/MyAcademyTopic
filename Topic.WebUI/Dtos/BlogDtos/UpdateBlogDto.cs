﻿using Topic.WebUI.Dtos.CategoryDtos;

namespace Topic.WebUI.Dtos.BlogDtos
{
    public class UpdateBlogDto
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string CoverImageUrl { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }

        public int CategoryID { get; set; }
    }
}
