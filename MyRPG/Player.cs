using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace MyRPG
{
    class Player
    {
        private int xp;
        private float health;

        public string Name { get; }

        public int XP
        {
            get => xp;

            set
            {
                if (xp < value)
                    xp = value;
            }
        }

        public int Level
        {
            get
            {
                return 1 + XP / 1000;
            }
        }

        public float Health
        {
            get => health;

            set
            {
                if (value < 0)
                    health = 0;
                else if (value > MaxHealth)
                    health = MaxHealth;
                else
                    health = value;
            }
        }

        public float MaxHealth
        {
            get => 100 + (Level - 1) * 20;
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;
            XP += (int)damage / 20;
        }

        public Player(string playerName)
        {
            Name = playerName;
            xp = 0;
            Health = MaxHealth;
        }
    }
}
