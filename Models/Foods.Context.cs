﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FoodsEntities : DbContext
    {
        public FoodsEntities()
            : base("name=FoodsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ArticleCategory> ArticleCategory { get; set; }
        public virtual DbSet<ArticleCom> ArticleCom { get; set; }
        public virtual DbSet<ArticleReply> ArticleReply { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Collect> Collect { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<FoodCategory> FoodCategory { get; set; }
        public virtual DbSet<FoodCom> FoodCom { get; set; }
        public virtual DbSet<FoodReply> FoodReply { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Special> Special { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<View_ArticleType> View_ArticleType { get; set; }
        public virtual DbSet<View_ArticleUsers> View_ArticleUsers { get; set; }
        public virtual DbSet<View_FoodUsers> View_FoodUsers { get; set; }
        public virtual DbSet<View_MenuFood> View_MenuFood { get; set; }
        public virtual DbSet<View_SpecialFood> View_SpecialFood { get; set; }
    }
}
