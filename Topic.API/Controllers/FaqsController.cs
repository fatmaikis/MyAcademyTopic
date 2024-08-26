using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Topic.BusinessLayer.Abstract;
using Topic.DTOLayer.DTOs.FaqDtos;
using Topic.EntityLayer.Entities;

namespace Topic.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FaqsController : ControllerBase
	{
		private readonly IFaqService _faqService;
		private readonly IMapper _mapper;

		public FaqsController(IFaqService faqService, IMapper mapper)
		{
			_faqService = faqService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult GetAllFaq()
		{
			var values = _faqService.TGetList();
			var faq = _mapper.Map<List<ResultFaqDto>>(values);
			return Ok(faq);
		}

		[HttpPost]
		public IActionResult CreateQuestion(CreateFaqDto createFaqDto)
		{
			var values = _mapper.Map<FAQ>(createFaqDto);
			_faqService.TCreate(values);
			return Ok("Cevap  eklendi");
		}

		[HttpGet("{id}")]

		public IActionResult GetFaqById(int id)
		{
			var values = _faqService.TGetById(id);
			var faq = _mapper.Map<ResultFaqDto>(values);
			return Ok(faq);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteFaq(int id)
		{
			_faqService.TDelete(id);
			return Ok("Cevap  silindi");
		}

		[HttpPut]
		public IActionResult UpdateQuestion(UpdateFaqDto updateFaqDto)
		{
			var values = _mapper.Map<FAQ>(updateFaqDto);
			_faqService.TUpdate(values);
			return Ok("Cevap güncellendi");
		}
	}
}
