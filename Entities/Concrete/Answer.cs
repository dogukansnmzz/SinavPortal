using Core.Entities.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Answer : BaseEntity,IEntity
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int QuestionId { get; set; }
    }
}
