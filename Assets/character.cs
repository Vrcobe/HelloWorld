
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace clasePlayer
{
    public abstract class character
    {

        public string name;
        private int kills;
        private int healthPoints;

        public character(string name)
        {
            this.name = name;
            this.healthPoints = 10;
            Debug.Log("Hola, soy" + name);
        }

        public int HealthPoints { get => healthPoints; set => healthPoints = value; }

        public int getKills()
        {
            return kills;
        }
        public virtual void TakeDamage()
        {
            healthPoints -= 1;
        }
    }
}
