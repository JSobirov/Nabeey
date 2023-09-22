﻿using Nabeey.Domain.Assets;
using Nabeey.Domain.Commons;
using Nabeey.Domain.Entities.QuestionAnswers;

namespace Nabeey.Domain.Entities.Questions;

public class Question : Auditable
{
    public long AssetId { get; set; }
    public Asset Asset { get; set; }
    public string Text { get; set; }
    public ICollection<QuestionAnswer> QuestionAnswers { get; set; }
}
