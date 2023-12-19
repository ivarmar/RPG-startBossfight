using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal interface IEnemy
    {
        string Name { get; }
        int Health { get; set; }

        int Stamina { get; set; }


        void Attack(GameCharacter target);

    }
}
