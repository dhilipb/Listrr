﻿using Listrr.Data;
using Listrr.Data.Trakt;

using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Listrr.Repositories
{
    public class TraktMovieRepository : ITraktMovieRepository
    {
        private readonly AppDbContext _appDbContext;

        public TraktMovieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<IList<TraktMovieCertification>> GetCertifications()
        {
            return await _appDbContext.TraktMovieCertifications.OrderBy(x => x.Description).ToListAsync();
        }

        public async Task<IList<TraktMovieGenre>> GetGenres()
        {
            return await _appDbContext.TraktMovieGenres.ToListAsync();
        }
    }
}