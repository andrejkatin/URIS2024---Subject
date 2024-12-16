using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using URIS2024___Subject.Data;
using URIS2024___Subject.Models.DTO;

namespace URIS2024___Subject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubjectController : Controller
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IMapper _mapper;

        public SubjectController(ISubjectRepository subjectRepository, IMapper mapper)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<SubjectDto> GetSubjectById(Guid id)
        {
            var subject = _subjectRepository.GetSubjectEntityById(id);
            if (subject == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<SubjectDto>(subject));
        }
    }
}
