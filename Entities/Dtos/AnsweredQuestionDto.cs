using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class AnsweredQuestionDto : IDto
    {
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }

        public string UserEmail { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }

        public string QuestionTitle { get; set; }
        public string QuestionDescription { get; set; }

        public string AnswerName { get; set; }
        public string AnswerValue { get; set; }
    }
}
