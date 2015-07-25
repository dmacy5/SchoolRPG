/*  Andrew Macy
                */
using System;

namespace SchoolRPG
{
    class World
    {
        public readonly int MAX_DAY = 50;
        public readonly int MIN_DAY = 1;


        private World game = null;
        private Player player { get { return player; } set { player = value; } }
        private State currentState { get { return currentState; } set { currentState = value; } }
        private string quarter { get { return quarter; } set { quarter = value; } }
        private int day { get { return day; } set { day = value; } }
        private Contacts contacts { get { return contacts; } set { contacts = value; } }

        private World()
        {
            this.player = new Player("Player");
            this.currentState = new AtStart();
            this.quarter = "Fall";
            this.day = MIN_DAY;
            this.contacts = new Contacts();
            this.game = this;
        }

        public World getInstance()
        {
            if (game == null)
                return new World();
            return this.game;
        }
    }
}
