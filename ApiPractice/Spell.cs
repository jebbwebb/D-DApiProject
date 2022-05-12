using System.Collections.Generic;

namespace DND
{
    public class Spell
    {
        public string index { get; set; }
        public string name { get; set; }
        public List<string> desc { get; set; }
        public List<string> higher_level { get; set; }
        public string range { get; set; }
        public List<string> components { get; set; }
        public string material { get; set; }
        public bool ritual { get; set; }
        public string duration { get; set; }
        public bool concentration { get; set; }
        public string casting_time { get; set; }
        public int level { get; set; }
        public string attack_type { get; set; }
        public Damage damage { get; set; }
        public School school { get; set; }
        public List<Class> classes { get; set; }
        public List<Subclass> subclasses { get; set; }
        public string url { get; set; }
    }

    public class Damage
    {
        public Damage_Type damage_type { get; set; }
        public Dictionary<string, string> damage_at_slot_level { get; set; }
    }

    public class Damage_Type
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class School
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Class
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Subclass
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
