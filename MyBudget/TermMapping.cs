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
            { "ctyofdenveronline", "Utilities" },
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
            // health
            { "health", "Health" },
            { "walgreens", "Health" },
            { "salon velluto", "Health" },
            { "deanna woodroff", "Health" },
            { "ulta", "Health" },
            { "loreal", "Health" },
            { "alta vista dermato", "Health" },
            { "quest diag", "Health" },
            { "cu medicine", "Health" },
            { "endodontics", "Health" },
            // doggos
            { "petsmart", "Doggos" },
            { "krisers", "Doggos" },
            { "petco", "Doggos" },
            { "chewy", "Doggos" },
            { "red rocks", "Doggos" },
            { "animal care", "Doggos" },
            { "quality paws", "Doggos" },
            // auto
            { "gas", "Auto" },
            { "ferney", "Auto" },
            { "metro express", "Auto" },
            { "co motor vehicle", "Auto" },
            { "prkg denver", "Auto" },
            { "7-eleven", "Auto" },
            { "circle k", "Auto" },
            { "conoco", "Auto" },
            { "parkwell", "Auto" },
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
            // booze
            { "hb liquor", "Booze" },
            { "total wine", "Booze" },
            { "argonaut", "Booze" },
            { "sobo liquors", "Booze" },
            { "lone tree brewing", "Booze" },
            // entertainment
            { "netflix", "Entertainment" },
            { "youtube", "Entertainment" },
            { "iracing", "Entertainment" },
            { "level 7", "Entertainment" },
            { "humblebundle", "Entertainment" },
            { "humanutility", "Entertainment" }, // move slow and fix things stickers (donation to charity)
            { "ars technica", "Entertainment" },
            { "steam", "Entertainment" },
            // electronics
            { "best buy", "Electronics" },
            { "micro center", "Electronics" },
            { "backblaze", "Electronics" },
            { "newegg", "Electronics" },
            { "namecheap", "Electronics" },
            { "apple store", "Electronics" },
            // biking
            { "velosoul", "Biking" },
            { "roll massif", "Biking" },
            // home improvement
            { "ikea", "Home Improvement" },
            { "cost plus wld", "Home Improvement" },
            { "wm supercent", "Home Improvement" },
            { "lowes", "Home Improvement" },
            { "lowe's", "Home Improvement" },
            { "homedepot.com", "Home Improvement" },
            { "home depot", "Home Improvement" },
            { "oreck", "Home Improvement" },
            { "murdoch's ranch", "Home Improvement" },
            { "university hills a", "Home Improvement" }, // Ace Hardware in university Hills Plaza
            // clothes
            { "everlane", "Clothes" },
            { "mgemi", "Clothes" },
            { "uniqlo", "Clothes" },
            { "hautlk rack", "Clothes" },
            { "patagonia", "Clothes" },
            // shopping
            { "ebay", "Shopping" },
            { "fedex", "Shopping" },
            { "qvc", "Shopping" },
            { "fancy tiger", "Shopping" },
            // apple
            { "apple.com", "Apple" },
            // cash
            { "atm", "Cash" },
            { "venmo", "Cash" },
            { "apple cash", "Cash" }
        };
    }
}
