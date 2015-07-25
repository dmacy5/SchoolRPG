/*  Andrew Macy
                */
using System;


namespace SchoolRPG
{
    class Character
    {
        public readonly int MAX_HEALTH = 100;
        public readonly int MIN_HEALTH = 0;

        private string name { get{ return name; } set{ name = value; } }
        private string sex { get { return sex; } set { name = sex; } }
        private string title { get { return title; } set { title = value; } }
        private int intel { get{ return intel; } set{ intel = value; } }
        private int athl { get { return athl; } set { athl = value; } }
        private int conf { get { return conf; } set { conf = value; } }
        private int cha { get { return cha; } set { cha = value; } }
        private int reas { get { return reas; } set { reas = value; } }
        private int health { get { return health; } set { health = value; } }

        public Character(string name, string title)
        {
            this.name = name;
            this.title = title;
            this.intel = 10;
            this.athl = 10;
            this.conf = 10;
            this.cha = 10;
            this.reas = 10;
            this.health = MAX_HEALTH;
        }

        public Character( string name, string title, int intel, int athl, int conf, int cha, int reas )
        {
            this.name = name;
            this.title = title;
            this.intel = intel;
            this.athl = athl;
            this.conf = conf;
            this.cha = cha;
            this.reas = reas;
            this.health = MAX_HEALTH;
        }
    }
}
