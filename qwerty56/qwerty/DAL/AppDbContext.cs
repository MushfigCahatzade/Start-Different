﻿using Microsoft.EntityFrameworkCore;

namespace qwerty.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
    }
}
