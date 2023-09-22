﻿using Nabeey.Domain.Commons;
using Nabeey.Domain.Entities.Contexts;

namespace Nabeey.Domain.Users;

public class Article : Auditable
{
    public string Text { get; set; }
    public long ContentId { get; set; }
    public Content Content { get; set; }
}
