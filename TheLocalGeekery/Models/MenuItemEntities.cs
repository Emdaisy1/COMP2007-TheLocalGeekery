namespace TheLocalGeekery.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuItemEntities : DbContext
    {
        public MenuItemEntities()
            : base("name=MenuConnection")
        {
        }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

    }
}