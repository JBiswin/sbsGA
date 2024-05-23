using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Numerics;
using InputSytem;





namespace programc_
{

    internal class Program
    {

        static void process(int x)
        {
            Console.WriteLine(x + "의 값이 처리되었습니다.");
        }

        static void process(float x)
        {
            Console.WriteLine(x + "의 값이 처리되었습니다.");
        }

        static void process(string x)
        {
            Console.WriteLine(x + "의 값이 처리되었습니다.");
        }

        static void process(int x, int y)
        {
            Console.WriteLine(x + "의 값이 처리되었습니다.");
            Console.WriteLine(y + "의 값이 처리되었습니다.");
        }

        public enum State
        {
            IDLE = 1,
            MOVE,
            ATTACK,
            DIE

            //열거형에서 값을 특정한 위치에 새로 할당하게 되면 그다음의 값은 새로할당한
            //값의 +1이 됩니다.

        }

        public enum Chose
        {
            Maerine = 1,
            Firebet,
            Ghost
        }

        static void Main(string[] args)
        {
            #region 상속
            //상위클래스의 속성을 하위클래스가 사용할 수 있도록 설정해주는 기능입니다.

            //  Unit unit = new Unit();

            //  Marine marine = new Marine();
            //  
            //  marine.Show();

            //클래스의 상속관계에서 상위 클래스는 하위 클래스의 속성을 사용할 수 없으며
            //하위클래스는 상위클래스의 메모리를 포함한 상태로 메모리의 크기가 결정됩니다.


            #endregion


            #region 이름 공간
            //속성을 구분할 수 있도록 유효범위를 설정하는 영역입니다.

            //  Keyboard keyboard = new Keyboard();
            //  
            //  keyboard.Connect();

            #endregion


            #region 다형성
            //여러개의 서로 다른 객체가 동일한 기능을 서로 다른 방법으로 처리할 수 있는 작업입니다.

            //다형성은 컴파일 시점에 함수의 속성이 결정되는 정적 바인딩을 하지 않고 실행시간에
            //함수와 속성이 결정될 수 있는 동적바인딩을 가능하게 합니다.

            #region 함수의 오버로딩
            //같은 이름의 함수를 매개 변수의 자료형과 매개 변수의 수로 구분하여 여러 개를 선언할 수 있는 기능입니다.

            //함수의 오버로딩의 경우 함수의 매개 변수에 전달하는 인수의 형태를 보고 호출하므로 반환형으로 함수의 오버로딩은 생성할
            //수 없습니다.

            //  process(3,10);
            //  process("hellow");
            //  process(3);
            //  process(3.14f);


            #endregion


            #region 함수의 오버라이딩
            //상위 클래스에 있는 함수를 하위 클래스에서 재정의하여 사용하는 기능입니다.

            //함수의 오버라이딩은 상속 관계에서만 이루어지며 하위 클래스에서 함수를 재정의할 때
            //상위 클래스의 함수 형태와 일치해야 합니다.

            //  Marine marine = new Marine();
            //  
            //  marine.skill();

            //  Unit unit = new Ghost();
            //  
            //  unit.skill();

            #region 가상 함수
            //상속하는 클래스 내에서 같은 형태의 함수로 재정의될 수 있는 함수입니다.

            //가상 함수 실행시간에 상위 클래스에 대한 참조로 하위 클래스에 재정의된
            //함수를 호출할 수 있으며 접근지정자는 공개로 설정해야합니다.

            //  Unit unit = new Marine();
            //  
            //  unit.Show();
            //  
            //  unit = new Firebet();
            //  
            //  unit.Show();
            //  
            //  unit = new Ghost();
            //  
            //  unit.Show();



            #endregion


            #endregion

            #endregion


            #region 열거형
            //여러개의 상수를 하나의 컨테이너에서 관리하기 위해 사용하는 자료형입니다.


            //   State state = (State)2;
            //  
            //   switch(state)
            //   {
            //       case State.IDLE: Console.WriteLine("대기상태");
            //           break;
            //       case State.MOVE:
            //           Console.WriteLine("이동상태");
            //           break;
            //       case State.ATTACK:
            //           Console.WriteLine("공격상태");
            //           break;
            //       case State.DIE:
            //           Console.WriteLine("죽은상태");
            //           break;
            //      
            //        
            //  
            //  
            //  
            //  
            //  
            //  
            //   }

            #endregion



            #region 콘솔 입력

            //   string name = Console.ReadLine();
            //  
            //   Console.WriteLine("name 변수의값:" + name);
            //  
            //  
            //  
            //   int count = Convert.ToInt32(Console.ReadLine());
            //  
            //   Console.WriteLine("count 변수의값:" + count);


            #endregion



            #region 배럭





            Unit unit = null;

            int y = 0;

            while (1 == 1)
            {

            label:
                Console.WriteLine("유닛생성");
                Console.WriteLine("1.마린");
                Console.WriteLine("2.파이어벳");
                Console.WriteLine("3.고스트");



                int num = Convert.ToInt32(Console.ReadLine());
                int label;



               
                    
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("마린 생성");

                            unit = new Marine();
                        continue;
                        case 2:
                            Console.WriteLine("파이어벳 생성");
                            unit = new Firebet();
                        continue;
                    case 3:
                            unit = new Ghost();
                            Console.WriteLine("고스트 생성");
                        continue;
                    }

                    if (num <= 0 || num >= 4)
                    {
                        Console.WriteLine("잘못 입력하였습니다.");
                        goto label;
                    }
                

                break;

            }

            #endregion


        }
    }
}
