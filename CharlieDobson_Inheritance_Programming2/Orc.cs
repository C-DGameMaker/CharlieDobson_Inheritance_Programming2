using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_Inheritance_Programming2
{
    internal class Orc : Character
    {
        int _defense;

        public Orc(int defense) : base(string name, int health, int attackPower)
        {
            _defense = defense;
        }

        public override void Attack(Character targetCharacter)
        {
            base.Attack(targetCharacter);
        }

        public override void TakeDamage()
        {
            base.TakeDamage();
        }
    }
}
