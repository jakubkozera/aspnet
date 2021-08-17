using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API;

    public class ToDoContext : DbContext
    {
        public ToDoContext (DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }

        public DbSet<API.ToDo> ToDo { get; set; }
    }
