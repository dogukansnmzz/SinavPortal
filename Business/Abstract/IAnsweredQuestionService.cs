using Entities.Concrete;
using ResultsNetStandard.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnsweredQuestionService
    {
        IListDataResult<AnsweredQuestion> GetAnsweredQuestions();
        ISingleDataResult<AnsweredQuestion> GetByAnsweredQuestionId(int answeredQuestionId);

        IResult Add(AnsweredQuestion answeredQuestion);
        IResult Delete(AnsweredQuestion answeredQuestion);
        IResult Update(AnsweredQuestion answeredQuestion);
    }
}
