﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace myProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class myProjectEntities : DbContext
    {
        public myProjectEntities()
            : base("name=myProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<吐司類> 吐司類 { get; set; }
        public virtual DbSet<蛋餅類> 蛋餅類 { get; set; }
        public virtual DbSet<單點> 單點 { get; set; }
        public virtual DbSet<飲料> 飲料 { get; set; }
        public virtual DbSet<漢堡類> 漢堡類 { get; set; }
    }
}
