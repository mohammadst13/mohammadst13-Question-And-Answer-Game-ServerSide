using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Question_And_Answer_Game_ServerSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question_And_Answer_Game_ServerSide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly QuizContext context;
        public QuestionsController(QuizContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Models.Question>> Get()
        {
            return new Models.Question[] 
            { 
                new Question(){Text = "Mohammad"},
                new Question(){Text = "tehrani"},
            };
        }
        [HttpPost]
        public void Post([FromBody] Models.Question question)
        {
            context.Questions.Add(question);
            context.SaveChanges();
        }
    }
}
