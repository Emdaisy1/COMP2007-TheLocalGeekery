using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheLocalGeekery.Models;

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