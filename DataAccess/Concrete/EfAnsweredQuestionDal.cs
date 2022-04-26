using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfAnsweredQuestionDal : EfEntityRepositoryBase<AnsweredQuestion, SınavPortalDb>, IAnsweredQuestionDal
    {
        public AnsweredQuestionDto GetDto(Expression<Func<AnsweredQuestionDto, bool>> filter)
        {
            using (var context = new SınavPortalDb())
            {
                var join = from answeredQuestion in context.AnsweredQuestions
                           join question in context.Questions on answeredQuestion.QuestionId equals question.Id
                           join user in context.Users on answeredQuestion.UserId equals user.Id
                           join answer in context.Answers on answeredQuestion.AnswerId equals answer.Id
                           select new AnsweredQuestionDto()
                           {

                           };
                return join.Where(filter).SingleOrDefault();
            }
        }

        public List<AnsweredQuestionDto> GetDtoAll(Expression<Func<AnsweredQuestionDto, bool>> filter = null)
        {
            using (var context = new SınavPortalDb())
            {
                var join = from answeredQuestion in context.AnsweredQuestions
                           join question in context.Questions on answeredQuestion.QuestionId equals question.Id
                           join user in context.Users on answeredQuestion.UserId equals user.Id
                           join answer in context.Answers on answeredQuestion.AnswerId equals answer.Id
                           select new AnsweredQuestionDto()
                           {

                           };
                return filter == null ? join.ToList() : join.Where(filter).ToList();
            }
        }
    }
}
