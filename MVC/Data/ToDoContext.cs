using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC;

    public class ToDoContext : DbContext
    {
        public ToDoContext (DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }

        public DbSet<MVC.ToDo> ToDo { get; set; }
    }
