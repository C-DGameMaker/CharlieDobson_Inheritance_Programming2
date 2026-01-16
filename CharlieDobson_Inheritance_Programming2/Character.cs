using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

/*
 * create a Character class with the following: 
Properties:
Health
Name 
AttackPower
Methods:
virtual void Attack(Character targetCharacter)
Writes a context message to the console and then calls TakeDamage on the targetCharacter 
 virtual void TakeDamage()
 * */

namespace CharlieDobson_Inheritance_Programming2
{
    internal class Character
    {
        //properties
        public string Name { get; set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }

        public Character(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        //Methods
        public virtual void Attack(Character targetCharacter)
        {

        }


        public virtual void TakeDamage()
        {

        }
    }
}
