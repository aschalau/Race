using System;
using CharacterLib;
// TODO: Thoughts - Base Race Class should potentially be static / abstract for the races below?
// TODO: create all these (sub)races with the correct attribute modifiers:
//          - Dwarf +2 Con
//              - Mountain +2 Str
//              - Hill +1 Wis
//          - Elf +2 Dex
//              - Drow +1 Cha
//              - High +1 Int
//              - Wood +1 Wis
//          - Halfling +2 Dex
//              - Lightfoot +1 Cha
//              - Stout +1 Con
//          - Human +1 Str, +1 Dex, +1 Con, +1 Int, +1 Wis, +1 Cha
//          - Dragonborn +2 Str, +1 Cha
//          - Gnome +2 Int
//              - Forest +2 Dex
//              - Rock +1 Con
//          - Half-Elf +2 Str, +2 Cha
//          - Half-Orc + 1 Con
//          - Tiefling +1 Int, +2 Cha
namespace RaceLib
{
    public abstract class Race : Character
    {
        abstract public int RaceModifiers();
    }

    public class Dwarf : Race
    {
        public override int RaceModifiers()
        {
            return 2;
        }
    }

    public class MountainDwarf : Dwarf
    {
        public override int RaceModifiers()
        {
            return 2;
        }
    }

    public class HillDwarf : Dwarf
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }

    public class Elf : Race
    {
        public override int RaceModifiers()
        {
            return 2;
        }
    }

    public class Drow : Elf
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }

    public class High : Elf
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }

    public class Wood : Elf
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }
}
