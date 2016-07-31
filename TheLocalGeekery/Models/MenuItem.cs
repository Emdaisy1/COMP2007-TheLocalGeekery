using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheLocalGeekery.Models;

//Author: Emma Hilborn - 200282755
//File: MenuItem.cs
//Website: http://thelocalgeekery.azurewebsites.net/
//Date: July 31, 2016
//Version: 1.0.0
//Description: Page to define the MenuItem model

namespace TheLocalGeekery.Models
{
    public class MenuItem
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public MenuItem()
        {

        }
        [Key]
        public virtual int ItemId { get; set; }
        public virtual string ItemType { get; set; }
        public virtual string ItemName { get; set; }
        public virtual string ItemIconUrl { get; set; }
        public virtual string ItemImageUrl { get; set; }
        public virtual string ItemDescription { get; set; }
        public virtual decimal ItemPrice { get; set; }

    }
}