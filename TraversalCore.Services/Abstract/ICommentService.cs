﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Services.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> TGetDestinationById(int id);
        List<Comment> TGetListCommentWithDestination();
    }
}
