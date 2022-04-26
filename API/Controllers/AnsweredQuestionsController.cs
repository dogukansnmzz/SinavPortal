using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnsweredQuestionsController : ControllerBase
    {
        private IAnsweredQuestionService AnsweredQuestionService { get; }

        public AnsweredQuestionsController(IAnsweredQuestionService answeredQuestionService)
        {
            AnsweredQuestionService = answeredQuestionService;
        }

        [HttpPost("add")]
        public IActionResult Add(AnsweredQuestion answeredQuestion)
        {
            var result = AnsweredQuestionService.Add(answeredQuestion);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(AnsweredQuestion answeredQuestion)
        {
            var result = AnsweredQuestionService.Delete(answeredQuestion);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(AnsweredQuestion answeredQuestion)
        {
            var result = AnsweredQuestionService.Update(answeredQuestion);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get-answered-questions")]
        public IActionResult GetAnsweredQuestions()
        {
            var result = AnsweredQuestionService.GetAnsweredQuestions();
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("get-by-answered-question-id/{answeredQuestionId}")]
        public IActionResult GetByAnsweredQuestionId(int answeredQuestionId)
        {
            var result = AnsweredQuestionService.GetByAnsweredQuestionId(answeredQuestionId);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
