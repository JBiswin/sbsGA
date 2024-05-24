using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace class_8th_다형성_
{
    internal class Marine : Unit
    {

        private int steamPack;


        public Marine()
        {
            health = 40;
            attack = 5;
            defense = 0;

            steamPack = 5;

            Console.WriteLine("create Marine");
        }

       override public void Show()
        {
            Console.WriteLine("health 변수의 값: " + health);
            Console.WriteLine("attack 변수의 값: " + attack);
            Console.WriteLine("defense 변수의 값: " + defense);
        }

        new public void skill()
        {
            Console.WriteLine("steampcak");
        }


    }
}
