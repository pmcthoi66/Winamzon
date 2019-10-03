﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winamz.Data.Infrastructure;
using Winamz.Model.Models;

namespace Winamz.Data.Repositories
{
    public interface IFeedbackRepository : IRepository<Feedback>
    {

    }
    public class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
