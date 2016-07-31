namespace TheLocalGeekery.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    //Author: Emma Hilborn - 200282755
    //File: MenuItemEntities.cs
    //Website: http://thelocalgeekery.azurewebsites.net/
    //Date: July 31, 2016
    //Version: 1.0.0
    //Description: Page to link model and data pages for items in database

    public partial class MenuItemEntities : DbContext
    {
        public MenuItemEntities()
            : base("name=MenuConnection")
        {
        }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

    }
}