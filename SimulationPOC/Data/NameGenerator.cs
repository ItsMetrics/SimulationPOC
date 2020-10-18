using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationPOC.Data
{
    class NameGenerator
    {
        List<string> prefix = new List<string>()
        {
            "Tomorrow",
            "Daddy",
            "Hope of",
            "Summer",
            "Autumn",
            "Last",
            "Early",
            "My Wife",
            "Strong",
            "Dog",
            "Not",
            "Better Than",
            "Skip",
            "Bethany",
            "My Ex",
            "True",
            "Mittens",
            "Forgot About",
            "Challenger",
            "Inquisitor",
            "God King",
            "Seperate",
            "David",
            "Free",
            "Pasta",
            "Surfin'",
            "Two Kids",
            "No Children",
            "Prime",
            "Final",
            "Hot Dog",
            "Stephen",
            "NAME NOT FOUND"
        };

        List<string> suffix = new List<string>()
        {
            " Glue",
            "'s Home",
            " Nothing",
            " The Moment",
            " Lovin' it",
            " Leg Day",
            " The Benjamin's",
            " Jessica",
            ", The Horse That Can Drive Itself",
            " The Destroyer",
            " Hats",
            " Inscrutible",
            ", No Last Name",
            " Cider",
            " Equal",
            " Spelled Backwards",
            " Riser",
            " Steamer",
            " Secret Car",
            " In A Trenchcoat",
            " Faith",
            " The Unyielding", 
            " The Day",
            " In Last Place",
            " Probably Cheats",
            " Wednesday",
            " Telephone",
            " Suspect",
            " Time",
            ", Who Shelters All"
        };

        public string GenerateName()
        {
            Random rand = new Random();
            string name = prefix[rand.Next(prefix.Count)] + suffix[rand.Next(suffix.Count)];
            return name;
        }
    }
}
