﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.EntityLayer.Entities;

namespace Topic.BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog> 
    {
        List<Blog> TGetBlogsWithCategories();
        Blog TGetBlogWithCategoryById(int id);

        List<Blog> TGetBlogsByCategoryId(int id);

    }
}
