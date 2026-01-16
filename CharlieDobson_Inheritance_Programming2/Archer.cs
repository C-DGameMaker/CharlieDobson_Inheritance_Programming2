using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_Inheritance_Programming2
{
    internal class Archer : Character
    {
        int _defense;
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
