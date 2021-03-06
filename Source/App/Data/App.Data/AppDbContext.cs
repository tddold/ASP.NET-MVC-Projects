﻿namespace App.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Common.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

<<<<<<< HEAD
        public IDbSet<Joke> Jokes { get; set; }

        public IDbSet<JokeCategory> JokeCategories { get; set; }
=======
        public IDbSet<Product> Products { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Image> Images { get; set; }

        public IDbSet<Order> Orders { get; set; }

        public IDbSet<OrderItem> OrderItems { get; set; }

        public IDbSet<Page> Pages { get; set; }

        public IDbSet<Promotion> Promotions { get; set; }

        public IDbSet<PromotionItem> PromotionItems { get; set; }
>>>>>>> 6ca5c2744ff07e9ad93c0f5627d37f5deea149bf

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }
}