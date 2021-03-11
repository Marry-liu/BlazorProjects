﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Data
{
    public class OrderDbContext: DbContext
    {
        /// <summary>
        /// Magic string.
        /// </summary>
        public static readonly string RowVersion = nameof(RowVersion);
        /// <summary>
        /// Magic strings.
        /// </summary>
        public static readonly string ContactsDb = nameof(ContactsDb).ToLower();
        /// <summary>
        /// Inject options.
        /// </summary>
        /// <param name="options">The <see cref="DbContextOptions{ContactContext}"/>
        /// for the context
        /// </param>
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        {
           // Debug.WriteLine($"{ContextId} context created.");
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<Transation> Transations { get; set; }
        public DbSet<TransArticle> TransArticles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<PrintParameter> PrintParameter { get; set; }
        public DbSet<Cost> Costs { get; set; }
        /// <summary>
        /// Define the model.
        /// </summary>
        /// <param name="modelBuilder">The <see cref="ModelBuilder"/>.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // this property isn't on the C# class
            // so we set it up as a "shadow" property and use it for concurrency
            //modelBuilder.Entity<Article>()
            //    .Property<byte[]>(RowVersion)
            //    .IsRowVersion();
            //modelBuilder.Entity<ArticleCategory>()
            //    .Property<byte[]>(RowVersion)
            //    .IsRowVersion();
            //base.OnModelCreating(modelBuilder);
        }
        /// <summary>
        /// Dispose pattern.
        /// </summary>
        public override void Dispose()
        {
            //Debug.WriteLine($"{ContextId} context disposed.");
            base.Dispose();
        }
        /// <summary>
        /// Dispose pattern.
        /// </summary>
        /// <returns>A <see cref="ValueTask"/></returns>
        public override ValueTask DisposeAsync()
        {
            //Debug.WriteLine($"{ContextId} context disposed async.");
            return base.DisposeAsync();
        }
    }
}
