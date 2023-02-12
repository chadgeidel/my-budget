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
            { "edeposit in branch", "Income" }, // check deposit from iOS app
            { "geidel,barbara", "Income" }, // transfer from mom at BHFCU
            { "deposit", "Income" }, // transfer from mom at BHFCU

            // tax
            { "irs treas", "Tax" }, // federal refund
            { "costtaxrfd", "Tax" }, // co state refund
            { "manion", "Tax" }, // chad tax preparer
            { "montue, woodard", "Tax" }, // dana tax preparer

            // cg consulting llc
            { "sos registration fee", "Biz" },

            // bank transfer and payments
            { "recurring transfer", "Bank" },
            { "payment transfer", "Bank" },
            { "online payment", "Bank" },
            { "dda to dda", "Bank" },
            { "online transfer", "Bank" },
            { "from share 0001", "Bank" },
            { "from share 0002", "Bank" },
            { "to share 0001", "Bank" },
            { "overdraft", "Bank" },
            { "credit card auto pay", "Bank" },
            { "acctverify", "Bank" },
            { "harland clarke check", "Bank" },

            // cc payment
            { "to loan 0141", "CC Payment" }, // bhfcu cc
            { "to visa signature card xxxxxxxxxxxx5846", "CC Payment" }, // wf cc
            { "cash back redemption", "CC Payment" }, // wf cc cashback
            { "payment thank you", "CC Payment" }, // wf cc
            { "automatic payment", "CC Payment" }, // wf cc

            // cc interest
            { "interest charge", "CC Interest"}, // wf cc

            // mortgage / rent
            { "mortgage", "Mortgage Rent" },
            { "turbotenan", "Mortgage Rent" },

            // utilities
            { "xcel", "Utilities" },
            { "denver water", "Utilities" },
            { "comcast", "Utilities" },
            { "xfinity", "Utilities" },
            { "vzwrlss", "Utilities" },
            { "cityofdenveronline", "Utilities" },
            { "mobile 888-936-4968 pa", "Utilities" }, // xfinity mobile likely
            { "denver 800-266-2278 co", "Utilities" }, // ??? $25 charge to BHFCU CC

            // insurance
            { "northwestern mu", "Insurance" },
            { "geico", "Insurance" },
            { "agi*renters", "Insurance" },
            { "transunion", "Insurance" },

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
            { "family fare", "Groceries" },
            { "primo water", "Groceries" },

            // self-care
            { "salon velluto", "Self-care" },
            { "perga", "Self-care" },
            { "ulta", "Self-care" },
            { "loreal", "Self-care" },
            { "beautypie", "Self-care" },
            { "beauty pie", "Self-care" },
            { "evolvetogether", "Self-care" },

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
            { "aesthetic nurse", "Health" },
            { "pretavoir glasgow", "Health" },

            // doggos
            { "petsmart", "Doggos" },
            { "krisers", "Doggos" },
            { "petco", "Doggos" },
            { "chewy", "Doggos" },
            { "red rocks", "Doggos" },
            { "animal care", "Doggos" },
            { "quality paws", "Doggos" },
            { "fine pet", "Doggos" },
            { "veterinary", "Doggos" },

            // auto maintenance
            { "ferney", "Auto Maint" },
            { "co motor vehicle", "Auto Maint" },
            { "air care colorado", "Auto Maint" },
            { "black hills tire", "Auto Maint" },

            // auto
            { "gas", "Auto" },
            { "shell oil", "Auto" },
            { "metro express", "Auto" },
            { "prkg denver", "Auto" },
            { "prkg metr denver", "Auto" },
            { "7-eleven", "Auto" },
            { "circle k", "Auto" },
            { "conoco", "Auto" },
            { "parkwell", "Auto" },
            { "car wash", "Auto" },
            { "lyft", "Auto" },
            { "uber", "Auto" },
            { "pilot", "Auto" },
            { "lotus", "Auto" },
            { "frroogle", "Auto" }, // peak to peak miata club
            { "yesway", "Auto" },
            { "big d", "Auto" },
            { "johnson corner", "Auto" },
            { "parking", "Auto" },
            { "holiday stations", "Auto" },
            { "phillips 66", "Auto" },
            { "cenex", "Auto" },
            { "loaf n jug", "Auto" },
            { "kum&go", "Auto" },
            { "arts complex garage", "Auto" },
            { "autozone", "Auto" },
            { "prairie auto", "Auto" },
            { "oceans express", "Auto" },
            { "s&s", "Auto" },

            // restaurants
            { "tejado", "Restaurants" },
            { "good times", "Restaurants" },
            { "tasty house", "Restaurants" },
            { "kaos", "Restaurants" },
            { "illegal pete", "Restaurants" },
            { "snarfosaurus", "Restaurants" },
            { "snarfs", "Restaurants" },
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
            { "pizzeria", "Restaurants" },
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
            { "qdoba", "Restaurants" },
            { "la cocina", "Restaurants" },
            { "subway", "Restaurants" },
            { "cheese ranch", "Restaurants" },
            { "gyro hub", "Restaurants" },
            { "yum yum spice", "Restaurants" },
            { "crave mediterranean", "Restaurants" },
            { "pearl of siam", "Restaurants" },
            { "gque", "Restaurants" },
            { "noodles & co", "Restaurants" },
            { "papa murphys", "Restaurants" },
            { "papa murphy's", "Restaurants" },
            { "chick-fil-a", "Restaurants" },
            { "panera bread", "Restaurants" },
            { "the spot cafe", "Restaurants" },
            { "lucky bird", "Restaurants" },
            { "little man ice", "Restaurants" },
            { "in n out burger", "Restaurants" },
            { "zoe ma ma", "Restaurants" },
            { "asian bistro", "Restaurants" },
            { "the bluegrass", "Restaurants" },
            { "blue bonnet", "Restaurants" },
            { "culvers", "Restaurants" },
            { "clancy irish pub", "Restaurants" },
            { "seamless.com", "Restaurants" },
            { "the golden mill", "Restaurants" },
            { "panaderia luna", "Restaurants" }, // bakery
            { "walters 303", "Restaurants" },
            { "two brothers idaho", "Restaurants" },
            { "cilantroandperejil", "Restaurants" },
            { "summer nights black hawk", "Restaurants" },

            // coffee
            { "coffee", "Coffee" },
            { "dunkin", "Coffee" },
            { "starbucks", "Coffee" },
            { "corvus", "Coffee" },
            { "bean fosters", "Coffee" },
            { "tea street", "Coffee" },

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
            { "lost cabin beer", "Booze" },
            { "hay camp", "Booze" },
            { "independent ale house", "Booze" },
            { "tap house", "Booze" },
            { "total beverage", "Booze" },
            { "lowry beer garden", "Booze" },
            { "bear valley wine", "Booze" },
            { "barquentine", "Booze" },            
            { "broncos pkwy wine", "Booze" },
            { "edward's tobacco", "Booze" },
            { "union lodge no. 1", "Booze" },
            { "whispers bar", "Restaurants" },

            // entertainment
            { "netflix", "Entertainment" },
            { "youtube", "Entertainment" },
            { "humanutility", "Entertainment" }, // move slow and fix things stickers (donation to charity)
            { "ars technica", "Entertainment" },
            { "alamo", "Entertainment" },
            { "booksamillion", "Entertainment" },
            { "maximum fun", "Entertainment" },
            { "bikram@maximu", "Entertainment" }, // also maximum fun podcast
            { "hiveworks", "Entertainment" }, // zach weiner
            { "tattered cover", "Entertainment" }, 
            { "hulu", "Entertainment" },
            { "nintendo", "Entertainment" },
            { "amc", "Entertainment" },
            { "deadly darling gifts", "Entertainment" }, // voicecoil music 
            { "premium httpswww.news ma", "Entertainment" }, // something Chad bought from BHFCU CC

            // hobbies
            { "fancy tiger", "Hobbies" },
            { "iracing", "Hobbies" },
            { "virtual racing school", "Hobbies" },
            { "steam", "Hobbies" },
            { "humblebundle", "Hobbies" },
            { "level 7", "Hobbies" },
            { "kickstarter.com", "Hobbies" },
            { "etsy.com", "Hobbies" },
            { "meininger art supp", "Hobbies" },
            { "merchant and mills rye", "Hobbies" },
            
            // electronics
            { "best buy", "Electronics" },
            { "micro center", "Electronics" },
            { "backblaze", "Electronics" },
            { "newegg", "Electronics" },
            { "namecheap", "Electronics" },
            { "apple store", "Electronics" },
            { "evga", "Electronics" },
            { "htc corp", "Entertainment" },
            { "1password", "Entertainment" },
            { "deciphertools.com", "Entertainment" },
            { "microsoft*subscription", "Entertainment" },
            
            // biking
            { "velosoul", "Biking" },
            { "roll massif", "Biking" },
            { "bikereg.com", "Biking" },
            { "outside events", "Biking" },
            { "allianzins.us", "Biking" }, // pretty sure this is insurance for bike ride
            { "acme bicycles", "Biking" }, // rapid city
            { "black hills bicycle", "Biking" }, // rapid city
            { "scheels", "Biking" },

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
            { "best service company", "Home Improvement" }, 

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
            { "emmaonesock", "Clothes" },

            // shopping
            { "ebay", "Shopping" },
            { "fedex", "Shopping" },
            { "qvc", "Shopping" },
            { "instacart", "Shopping" },
            { "instacar", "Shopping" },
            { "the ups store", "Shopping" },
            { "usps", "Shopping" },

            // apple
            { "apple.com", "Apple" },

            // cash
            { "atm", "Cash" },
            { "venmo", "Cash" },
            { "apple cash", "Cash" },
            { "withdrawal made", "Cash" },
            { "etip", "Cash" },
            { "international purchase transaction fee", "Cash" },

            // travel
            { "la quinta", "Travel" },
            { "southwes", "Travel" },

            // legal
            { "sh law", "Legal" },
            { "montgomery little soran", "Legal" }
        };
    }
}
