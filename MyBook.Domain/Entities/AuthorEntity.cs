﻿using MyBook.Domain.Entities.Base;

namespace MyBook.Domain.Entities
{
    public  class AuthorEntity : EntityBase<AuthorEntity>
    {
        public string Name { get; set; }
    }
}
