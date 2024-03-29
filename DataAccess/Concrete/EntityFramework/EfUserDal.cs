﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, EducationPortalContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (EducationPortalContext context = new EducationPortalContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = userOperationClaim.OperationClaimId,
                                 Name = operationClaim.Name
                             };

                return result.ToList();
            }
        }
    }
}