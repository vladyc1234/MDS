using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Data
{
    public class AppDbContext : IdentityDbContext<User, Role, int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<CookedWith> CookedWiths { get; set; }
        public DbSet<DerivedTag> DerivedTags { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<MadeWith> MadeWiths { get; set; }
        public DbSet<PullRecipe> PullRecipes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeTag> RecipeTags { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Utensil> Utensils { get; set; }
        public DbSet<RecipeLibrary> RecipeLibraries { get; set; }
        public DbSet<SessionToken> SessionTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
               .HasMany(a => a.Recipes)
               .WithOne(b => b.User);

            modelBuilder.Entity<Recipe>()
               .HasMany(a => a.PullRecipes)
               .WithOne(b => b.Recipe);

            modelBuilder.Entity<Recipe>()
               .HasMany(a => a.Reviews)
               .WithOne(b => b.Recipe);

            modelBuilder.Entity<Recipe>()
               .HasMany(a => a.Comments)
               .WithOne(b => b.Recipe);

            modelBuilder.Entity<Recipe>()
               .HasMany(a => a.Questions)
               .WithOne(b => b.Recipe);

            modelBuilder.Entity<Recipe>()
               .HasMany(a => a.DerivedRecipes)
               .WithOne(b => b.Recipe);



            // MadeWith
            modelBuilder.Entity<MadeWith>().HasKey(x => new { x.IdIngredient, x.IdRecipe });

            modelBuilder.Entity<MadeWith>()
                .HasOne(rf => rf.Recipe)
                .WithMany(r => r.MadeWiths)
                .HasForeignKey(rf => rf.IdRecipe);

            modelBuilder.Entity<MadeWith>()
                .HasOne(rf => rf.Ingredient)
                .WithMany(f => f.MadeWiths)
                .HasForeignKey(rf => rf.IdIngredient);



            // CookedWith
            modelBuilder.Entity<CookedWith>().HasKey(x => new { x.IdUtensil, x.IdRecipe });

            modelBuilder.Entity<CookedWith>()
                .HasOne(rf => rf.Recipe)
                .WithMany(r => r.CookedWiths)
                .HasForeignKey(rf => rf.IdRecipe);

            modelBuilder.Entity<CookedWith>()
                .HasOne(rf => rf.Utensil)
                .WithMany(f => f.CookedWiths)
                .HasForeignKey(rf => rf.IdUtensil);


            // RecipeTag
            modelBuilder.Entity<RecipeTag>().HasKey(x => new { x.IdTag, x.IdRecipe });

            modelBuilder.Entity<RecipeTag>()
                .HasOne(rf => rf.Recipe)
                .WithMany(r => r.RecipeTags)
                .HasForeignKey(rf => rf.IdRecipe);

            modelBuilder.Entity<RecipeTag>()
                .HasOne(rf => rf.Tag)
                .WithMany(f => f.RecipeTags)
                .HasForeignKey(rf => rf.IdTag);


            // DerivedTag
            modelBuilder.Entity<DerivedTag>().HasKey(x => new { x.IdTag, x.IdDerivedRecipe });

            modelBuilder.Entity<DerivedTag>()
                .HasOne(rf => rf.DerivedRecipe)
                .WithMany(r => r.DerivedTags)
                .HasForeignKey(rf => rf.IdDerivedRecipe);

            modelBuilder.Entity<DerivedTag>()
                .HasOne(rf => rf.Tag)
                .WithMany(f => f.DerivedTags)
                .HasForeignKey(rf => rf.IdTag);


            // RecipeLibrary
            modelBuilder.Entity<RecipeLibrary>().HasKey(x => new { x.IdLibrary, x.IdRecipe });

            modelBuilder.Entity<RecipeLibrary>()
                .HasOne(rf => rf.Recipe)
                .WithMany(r => r.RecipeLibraries)
                .HasForeignKey(rf => rf.IdRecipe);

            modelBuilder.Entity<RecipeLibrary>()
                .HasOne(rf => rf.Library)
                .WithMany(f => f.RecipeLibraries)
                .HasForeignKey(rf => rf.IdLibrary);


            base.OnModelCreating(modelBuilder);
        }
    }
}
