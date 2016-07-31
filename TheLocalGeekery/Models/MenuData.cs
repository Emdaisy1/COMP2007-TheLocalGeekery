using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TheLocalGeekery.Models
{
    public class MenuData : DropCreateDatabaseAlways<MenuItemEntities>
        
    {
        protected override void Seed(MenuItemEntities context)
        {
            new List<MenuItem>
            {
                new MenuItem { ItemId = 1, ItemType = "Dessert", ItemName = "Chocolate Frogs", ItemDescription = "NOT what they sound like! These are solid chocolate frogs, not chocolate-dipped frogs. Experience a Harry Potter style dessert - if yours doesn't hop away!", ItemIconUrl = "/Assets/images/chocoFrogsIcon.jpg", ItemImageUrl = "/Assets/images/chocoFrogsFull.jpg", ItemPrice = 5.99M },
                new MenuItem { ItemId = 2, ItemType = "Beverage", ItemName = "Butterbeer", ItemDescription = "We can't get you to Hogsmead with Floo Powder, but we may be able to get your taste buds there with this Butterbeer! Hot milk and sweet butterscotch. Non-alcoholic, despite the name.", ItemIconUrl = "/Assets/images/butterbeerIcon.jpg", ItemImageUrl = "/Assets/images/butterbeerFull.jpg", ItemPrice = 4.99M },
                new MenuItem { ItemId = 3, ItemType = "Appetizer", ItemName = "BBQ Buzzard Wings", ItemDescription = "When you need a break from the WoW Badlands, you and your crew can split some BBQ wings to chow down on. (Note: these are chicken wings.)", ItemIconUrl = "/Assets/images/buzzardWingsIcon.jpg", ItemImageUrl = "/Assets/images/buzzardWingsFull.jpg", ItemPrice = 6.99M },
                new MenuItem { ItemId = 4, ItemType = "Appetizer", ItemName = "Cheey Buns", ItemDescription = "We can't bake like Peeta Mellark - but we can come close. Try our take on his famous cheesy buns while you decide on a main meal.", ItemIconUrl = "/Assets/images/cheesyBunsIcon.jpg", ItemImageUrl = "/Assets/images/cheesyBunsFull.jpg", ItemPrice = 5.99M },
                new MenuItem { ItemId = 5, ItemType = "Main", ItemName = "Fish Fingers & Custard", ItemDescription = "Brave enough to see why the 11th Doctor likes this meal so much? Order and find out! (Note: Custard can be swapped for fries, for our less daring customers.)", ItemIconUrl = "/Assets/images/fishFingersCustardIcon.jpg", ItemImageUrl = "/Assets/images/fishFingersCustardFull.jpg", ItemPrice = 10.99M },
                new MenuItem { ItemId = 6, ItemType = "Appetizer", ItemName = "Lembas Bread", ItemDescription = "When you're hungry enough you need a full meal to start with, go for the Lembas bread - one bite is enough to fill a grown man's stomach for a full day! Inspired by LOTR, enjoy some of this sweet, light bread alone or with friends.", ItemIconUrl = "/Assets/images/lembasBreadIcon.jpg", ItemImageUrl = "/Assets/images/lembasBreadFull.jpg", ItemPrice = 7.99M },
                new MenuItem { ItemId = 7, ItemType = "Beverage", ItemName = "Nuka Cola", ItemDescription = "When the Fallout wastelands parch your throat, you can enjoy a fresh cold Nuka Cola. Fresh, fruity, and fizzy - ideal for pop-lovers.", ItemIconUrl = "/Assets/images/nukaColaIcon.jpg", ItemImageUrl = "/Assets/images/nukaColaFull.jpg", ItemPrice = 2.99M },
                new MenuItem { ItemId = 8, ItemType = "Dessert", ItemName = "Not-a-lie Cake", ItemDescription = "This cake is NOT a lie! We aren't part of PORTAL, don't worry. Just kick back and enjoy a slice of rich chocolate cake.", ItemIconUrl = "/Assets/images/portalCakeIcon.jpg", ItemImageUrl = "/Assets/images/portalCakeFull.jpg", ItemPrice = 8.99M },
                new MenuItem { ItemId = 9, ItemType = "Main", ItemName = "Rock Sirloin", ItemDescription = "Unlike the Gorons in Zelda, we don't use real rocks. Instead, we've created a juicy dish of steak, prosciutto, mushrooms and shallots wrapped in crispy puff pastry.", ItemIconUrl = "/Assets/images/rockSirloinIcon.jpg", ItemImageUrl = "/Assets/images/rockSirloinFull.jpg", ItemPrice = 13.99M },
                new MenuItem { ItemId = 10, ItemType = "Beverage", ItemName = "Romulan Ale", ItemDescription = "Savor the Star Trek galaxy's infamous Romulan Ale - just be aware of the hangover that will likely come with it! (Alcoholic - ID must be shown to order.)", ItemIconUrl = "/Assets/images/RomulanAleIcon.jpg", ItemImageUrl = "/Assets/imagesRomulanAleFull.jpg", ItemPrice = 7.99M },
                new MenuItem { ItemId = 11, ItemType = "Main", ItemName = "Yeto's Soup", ItemDescription = "All Zelda fans who've played Twilight Princess have had to wonder what Yeto the yeti's soup tastes like... give our version a try and see if it brings your strength back just like Yeto's!", ItemIconUrl = "/Assets/images/YetosSoupIcon.jpg", ItemImageUrl = "/Assets/images/YetosSoupFull.jpg", ItemPrice = 10.99M },
                new MenuItem { ItemId = 12, ItemType = "Dessert", ItemName = "Turkish Delight", ItemDescription = "We don't know if Narnia's turkish delight warranted Edmund selling out his siblings... but we know ours certainly does! Just don't bring your siblings if you plan to try this - we may make a deal over kitchen work.", ItemIconUrl = "/Assets/images/turkishDelightIcon.jpg", ItemImageUrl = "/Assets/images/turkishDelightFull.jpg", ItemPrice = 9.99M }
            }.ForEach(a => context.MenuItems.Add(a));
        }    
    }
}


//Sources:
//Chocolate frogs image from: https://www.candybarsydney.com.au/bulk-chocolate/1771-milk-chocolate-frogs-500g.html
//All other images from: http://www.geekychef.com/