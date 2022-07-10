using System.Collections.Generic;

namespace MyBudget
{
    class TermMapping
    {
        public static readonly Dictionary<string, string> SearchTermMapping = new()
        {
            // income
            { "colorado state", "Income" },
            { "interest payment", "Income" },
            { "mobile deposit", "Income" }, // check deposit from iOS app
            // tax
            { "irs treas", "Tax" }, // federal refund
            { "costtaxrfd", "Tax" }, // co state refund
            { "manion", "Tax" },
            // cg consulting llc
            { "sos registration fee", "Biz" },
            // cc payment
            { "to loan 0141", "CC Payment" }, // bhfcu cc
            { "to visa signature card xxxxxxxxxxxx5846", "CC Payment" }, // wf cc
            { "cash back redemption", "CC Payment" }, // wf cc cashback
            // cc interest
            { "interest charge", "CC Interest"}, // wf cc
            // mortgage
            { "mortgage", "Mortgage" },
            // utilities
            { "xcel", "Utilities" },
            { "denver water", "Utilities" },
            { "comcast", "Utilities" },
            { "xfinity", "Utilities" },
            { "vzwrlss", "Utilities" },
            { "cityofdenveronline", "Utilities" },
            // insurance
            { "northwestern mu", "Insurance" },
            { "geico", "Insurance" },
            // storage
            { "clearhome", "Storage" },
            // individual stores,
            { "target", "Target" },
            { "costco whse", "Costco" },
            { "amzn.com", "Amazon" },
            // groceries
            { "sprouts", "Groceries" },
            { "king soop", "Groceries" },
            { "water - coffee", "Groceries" },
            { "wholefds", "Groceries" },
            { "safeway", "Groceries" },
            { "natural grocers", "Groceries" },
            // self-care
            { "salon velluto", "Self-care" },
            { "ulta", "Self-care" },
            { "loreal", "Self-care" },
            { "beauty pie", "Self-care" },
            // medical
            { "health", "Health" },
            { "walgreens", "Health" },
            { "alta vista dermato", "Health" },
            { "quest diag", "Health" },
            { "cu medicine", "Health" },
            { "endodontics", "Health" },
            { "pharmacy", "Health" },
            { "new west physician", "Health" },
            { "carole emanuel dds", "Health" },
            { "university colorado", "Health" },
            { "university colorad", "Health" },
            { "uch ambulatory", "Health" },
            { "coast to coast comp", "Health" },
            { "coast to coast com", "Health" },
            // doggos
            { "petsmart", "Doggos" },
            { "krisers", "Doggos" },
            { "petco", "Doggos" },
            { "chewy", "Doggos" },
            { "red rocks", "Doggos" },
            { "animal care", "Doggos" },
            { "quality paws", "Doggos" },
            { "fine pet", "Doggos" },
            // auto
            { "gas", "Auto" },
            { "shell oil", "Auto" },
            { "ferney", "Auto" },
            { "metro express", "Auto" },
            { "co motor vehicle", "Auto" },
            { "prkg denver", "Auto" },
            { "prkg metr denver", "Auto" },
            { "7-eleven", "Auto" },
            { "circle k", "Auto" },
            { "conoco", "Auto" },
            { "parkwell", "Auto" },
            { "air care colorado", "Auto" },
            { "car wash", "Auto" },
            { "lyft", "Auto" },
            { "uber", "Auto" },
            { "pilot", "Auto" },
            { "black hills tire", "Auto" },
            { "lotus", "Auto" },
            { "frroogle", "Auto" }, // peak to peak miata club
            { "yesway", "Auto" },
            { "big d", "Auto" },
            { "johnson corner", "Auto" },
            // restaurants
            { "tejado", "Restaurants" },
            { "good times", "Restaurants" },
            { "tasty house", "Restaurants" },
            { "kaos", "Restaurants" },
            { "illegal pete", "Restaurants" },
            { "starbucks", "Restaurants" },
            { "corvus", "Restaurants" },
            { "snarfosaurus", "Restaurants" },
            { "five guys", "Restaurants" },
            { "rheinlander bakery", "Restaurants" },
            { "new image restaura", "Restaurants" },
            { "cochino taco", "Restaurants" },
            { "park burger", "Restaurants" },
            { "birdcall", "Restaurants" },
            { "mike's famous pizz", "Restaurants" },
            { "tankfoods", "Restaurants" },
            { "santiagos", "Restaurants" },
            { "miyako", "Restaurants" },
            { "dunkin", "Restaurants" },
            { "pizzeria", "Restaurants" },
            { "coffee", "Restaurants" },
            { "carls jr", "Restaurants" },
            { "mcdonald's", "Restaurants" },
            { "2 penguins", "Restaurants" },
            { "bbq", "Restaurants" },
            { "chipotle", "Restaurants" },
            { "marczyk", "Restaurants" },
            { "baked n denver", "Restaurants" },
            { "donuts", "Restaurants" },
            { "pho", "Restaurants" },
            { "kfc", "Restaurants" },
            { "motomaki", "Restaurants" },
            { "georgia boys bb", "Restaurants" },
            { "ice cream", "Restaurants" },
            { "deli", "Restaurants" },
            { "thai pot", "Restaurants" },
            { "taqueria jalisco", "Restaurants" },
            { "trompeau", "Restaurants" },
            { "park & co", "Restaurants" },
            // booze
            { "liquor", "Booze" },
            { "total wine", "Booze" },
            { "argonaut", "Booze" },
            { "lone tree brewing", "Booze" },
            { "prost", "Booze" },
            { "brewery", "Booze" },
            { "distillery", "Booze" },
            { "pint room", "Booze" },
            { "719-4345750", "Booze" },
            // entertainment
            { "netflix", "Entertainment" },
            { "youtube", "Entertainment" },
            { "humanutility", "Entertainment" }, // move slow and fix things stickers (donation to charity)
            { "ars technica", "Entertainment" },
            { "alamo", "Entertainment" },
            { "booksamillion", "Entertainment" },
            { "maximum fun", "Entertainment" },
            // hobbies
            { "fancy tiger", "Hobbies" },
            { "iracing", "Hobbies" },
            { "virtual racing school", "Hobbies" },
            { "steam", "Hobbies" },
            { "humblebundle", "Hobbies" },
            { "level 7", "Hobbies" },
            { "kickstarter.com", "Hobbies" },
            // electronics
            { "best buy", "Electronics" },
            { "micro center", "Electronics" },
            { "backblaze", "Electronics" },
            { "newegg", "Electronics" },
            { "namecheap", "Electronics" },
            { "apple store", "Electronics" },
            { "evga", "Electronics" },
            { "htc corp", "Entertainment" },
            // biking
            { "velosoul", "Biking" },
            { "roll massif", "Biking" },
            { "bikereg.com", "Biking" },
            { "outside events", "Biking" },
            { "allianzins.us", "Biking" }, // pretty sure this is insurance for bike ride
            // home improvement
            { "ikea", "Home Improvement" },
            { "cost plus wld", "Home Improvement" },
            { "wm supercent", "Home Improvement" },
            { "walmart", "Shopping" },
            { "lowes", "Home Improvement" },
            { "lowe's", "Home Improvement" },
            { "homedepot.com", "Home Improvement" },
            { "home depot", "Home Improvement" },
            { "oreck", "Home Improvement" },
            { "containerstore", "Home Improvement" },
            { "murdoch's ranch", "Home Improvement" },
            { "university hills a", "Home Improvement" }, // Ace Hardware in university Hills Plaza
            { "harbor freight", "Home Improvement" },
            { "ace hardware", "Home Improvement" }, 
            // clothes
            { "everlane", "Clothes" },
            { "mgemi", "Clothes" },
            { "uniqlo", "Clothes" },
            { "hautlk rack", "Clothes" },
            { "patagonia", "Clothes" },
            { "nordrack", "Clothes" },
            { "nordstrom", "Clothes" },
            { "baum-kuchen", "Clothes" },
            { "the orvis co", "Clothes" },
            // shopping
            { "ebay", "Shopping" },
            { "fedex", "Shopping" },
            { "qvc", "Shopping" },
            // apple
            { "apple.com", "Apple" },
            // cash
            { "atm", "Cash" },
            { "venmo", "Cash" },
            { "apple cash", "Cash" },
            // travel
            { "la quinta", "Travel" },
            // legal
            { "sh law", "Legal" }
        };
    }
}
