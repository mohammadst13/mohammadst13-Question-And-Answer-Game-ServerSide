﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return context.Questions;
        }

        [HttpGet("{quizId}")]
        public ActionResult<IEnumerable<Models.Question>> Get([FromRoute] int quizId)
        {
            return context.Questions.Where(q => q.QuizId == quizId).ToList();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Question question)
        {
            if (!context.Quizzes.Any(q => q.ID == question.QuizId))
            {
                return StatusCode(404);
            }
            context.Questions.Add(question);
            await context.SaveChangesAsync();

            return Ok(question);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Models.Question question)
        {
            if(id != question.ID)
            {
                return BadRequest();
            }

            context.Entry(question).State = EntityState.Modified;

            await context.SaveChangesAsync();

            return Ok(question);
        }
    }
}
