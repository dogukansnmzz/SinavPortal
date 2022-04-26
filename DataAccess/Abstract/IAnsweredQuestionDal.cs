using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAnsweredQuestionDal : IEntityRepository<AnsweredQuestion>
    {
        List<AnsweredQuestionDto> GetDtoAll(Expression<Func<AnsweredQuestionDto, bool>> filter = null);
        AnsweredQuestionDto GetDto(Expression<Func<AnsweredQuestionDto, bool>> filter);
    }
}
