﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraySystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BookLibrary : DbContext
    {
        public BookLibrary()
            : base("name=BookLibrary")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookIssue> BookIssues { get; set; }
        public virtual DbSet<BookRequest> BookRequests { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<BookAuthor> BookAuthors { get; set; }
    
        public virtual ObjectResult<Pro_GetCategory_Result> Pro_GetCategory()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pro_GetCategory_Result>("Pro_GetCategory");
        }
    }
}
