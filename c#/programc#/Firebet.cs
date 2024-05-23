using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programc_
{
    internal class Firebet : Unit
    {
       public Firebet()
        {
            health = 50;
            attack = 7;
            defense = 1;
        }

        new public void skill()
        {
            Console.WriteLine("steampcak");
        }

        public override void Show()
        {
            Console.WriteLine("health 변수의 값: " + health);
            Console.WriteLine("attack 변수의 값: " + attack);
            Console.WriteLine("defense 변수의 값: " + defense);
        }


    }
}
