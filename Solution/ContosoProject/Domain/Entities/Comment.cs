﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Comment:BaseEntity
    {
     
            public string Message { get; set; }

            public CommentType Type { get; set; }

    }
}
