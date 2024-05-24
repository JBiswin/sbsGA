using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_8th_다형성_
{
    internal class Unit
    {
        protected int health;
        protected int attack;
        protected int defense;



       public Unit()
        {
            Console.WriteLine("create Unit");
        }


        public void skill()
        {
            Console.WriteLine("Unit skill");
        }


        virtual public void Show()
        {

            Console.WriteLine("Unit Information");

            //가상함수의 경우 가상 함수 테이블을 사용하여 호출되는 함수를
            //실행시간에 결정하며 정적으로 선언된 함수는 가상 함수로 선언할 수 없습니다.
        }


    }
}
