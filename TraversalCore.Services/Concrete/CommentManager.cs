﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Repository.Abstract;
using TraversalCore.Entity.Concrete;
using TraversalCore.Services.Abstract;

namespace TraversalCore.Services.Concrete
{
    public class CommentManager : ICommentService
    {

        ICommentRepository _commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }


        public void TAdd(Comment entity)
        {
            _commentRepository.Insert(entity);
        }

        public void TDelete(Comment entity)
        {
            _commentRepository.Delete(entity);
        }

        public Comment TGetById(int id)
        {
            return _commentRepository.GetById(id);
        }

        public List<Comment> TGetList()
        {
            return _commentRepository.GetList();
        }

        public void TUpdate(Comment entity)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetDestinationById(int id)
        {
            return _commentRepository.GetListByFilter(x => x.DestinationId == id);
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return _commentRepository.GetListCommentWithDestination();
        }
    }
}
