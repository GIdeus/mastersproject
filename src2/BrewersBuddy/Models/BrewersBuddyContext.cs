﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BrewersBuddy.Models
{
    public class BrewersBuddyContext : DbContext
    {
        public BrewersBuddyContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Batch> Batches { get; set; }
        public DbSet<BatchNote> BatchNotes { get; set; }
        public DbSet<BatchAction> BatchActions { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<Cellar> Cellars { get; set; }
        public DbSet<BatchRating> BatchRatings { get; set; }
        public DbSet<BatchComment> BatchComments { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }
		public DbSet<webpages_Membership> webpages_Memberships { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}