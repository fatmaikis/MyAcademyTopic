using AutoMapper;
using Topic.DTOLayer.DTOs.FaqDtos;
using Topic.EntityLayer.Entities;

namespace Topic.API.Mappings
{
	public class FaqMapping :Profile
	{
        public FaqMapping()
        {
            CreateMap<CreateFaqDto, FAQ>().ReverseMap();
            CreateMap<UpdateFaqDto, FAQ>().ReverseMap();
            CreateMap<ResultFaqDto, FAQ>().ReverseMap();
        }
    }
}
