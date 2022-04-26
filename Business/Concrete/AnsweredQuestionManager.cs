using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using Results.State;
using ResultsNetStandard.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AnsweredQuestionManager : IAnsweredQuestionService
    {
        private IAnsweredQuestionDal AnsweredQuestionDal { get; }

        public AnsweredQuestionManager(IAnsweredQuestionDal answeredQuestionDal)
        {
            AnsweredQuestionDal = answeredQuestionDal;
        }

        [SecuredOperation("answeredquestion.add")]
        public IResult Add(AnsweredQuestion answeredQuestion)
        {
            AnsweredQuestionDal.Add(answeredQuestion);
            return new SuccessResult(Messages.SuccessAddOperation);
        }

        [SecuredOperation("answeredquestion.delete")]
        public IResult Delete(AnsweredQuestion answeredQuestion)
        {
            AnsweredQuestionDal.Add(answeredQuestion);
            return new SuccessResult(Messages.SuccessDeleteOperation);
        }

        public IListDataResult<AnsweredQuestion> GetAnsweredQuestions()
        {
            return new SuccessListDataResult<AnsweredQuestion>(AnsweredQuestionDal.GetAll());
        }

        public ISingleDataResult<AnsweredQuestion> GetByAnsweredQuestionId(int answeredQuestionId)
        {
            return new SuccessSingleDataResult<AnsweredQuestion>(AnsweredQuestionDal.Get(answeredQuestion => answeredQuestion.Id == answeredQuestionId));
        }

        [SecuredOperation("answeredquestion.update")]
        public IResult Update(AnsweredQuestion answeredQuestion)
        {
            AnsweredQuestionDal.Add(answeredQuestion);
            return new SuccessResult(Messages.SuccessUpdateOperation);
        }


    }
}
