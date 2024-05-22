namespace class_7th_class_
{
    public class GameObject
    {

        #region 바이트 패딩
        //멤버 변수를 메모리에서 cpu로 읽을 때 한번에 읽을수 있도록
        //컴파일러가 레지스터 블록에 맞추어 바이트를 패딩해주는 최적화 작업입니다.

        //클래스의 크기는 클래스를 구성하는 멤버 중에서 크기가 가장 큰 자료형의 배수가 되도록 설정합니다.

        //클래스의 크기의 경우 멤버 변수의 순서에 따라 메모리 크기가 다르게 설정될 수 있습니다.


        #endregion
        int x;
        int y;
        int z;

        private double weight;
        public void Information()
        {
            Console.WriteLine("x의 값: " + x);
            Console.WriteLine("y의 값: " + y);
            Console.WriteLine("z의 값: " + z);
        }


    }

    public class Collider
    {
        int size = 0;
        static int score = 0;

        public void IncreaseScore()
        {



            score++;

            Console.WriteLine("score 변수의 값: " + score);


        }
    }

    public class Unit
    {
        private int health;
        private string name;
        private int[] attack;

        public Unit(int health, string name)
        {

            //this 포인터
            //자기 자신의 객체를 가리키는 포인터 입니다.


            this.health = health;
            this.name = name;

            attack = new int[3];

        }


        public Unit(Unit unit)
        {
            health = unit.health;
            name = unit.name;
            attack = new int[3];
        }

        public void SetData(int value)
        {
            attack[0] = value;
        }


        public void Show()
        {

            Console.WriteLine("health 변수의 값:" + health);
            Console.WriteLine("name 변수의 값: " + name);
            for (int i = 0; i < attack.Length; i++)
            {
                Console.WriteLine("attack[" + i + "]" + "=" + attack[i]);
            }

        }


    }

    public class Position
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                if (value >= 100 && value < 0)
                {
                    Console.WriteLine("dd");
                }

                else
                {
                    y = value;
                }
            }
        }
    }


    internal class Program
    {


        static void Main(string[] args)
        {
            #region 클래스
            //사용자 정의 데이터 유형으로 속성과 함수가 포함되어 있으며
            //클래스를 통해 객체를 생성하여 접근하고 사용할 수 있는 집합체입니다.

            //  GameObject gameobject = new GameObject();
            //  
            //  gameobject.Information();

            //클래스의 경우 클래스 내부에 있는 클래스의 메모리영역에 포함되지만
            //정적변수와 함수의 메모리는 클래스 영역에 포함되지 않습니다.


            #endregion


            #region 변수의 범위
            #region 지역 변수

            //선언된 블록(영역){}안에서만 사용할 수 있으며 블록을 벗어나면 메모리에서
            //사라지는 특징을 가지고 있습니다.
            //  {
            //      int data;
            //      GameObject gmaeobject1 = new GameObject();
            //  }



            #endregion


            #region 정적 변수
            //프로그램이 실행될때 단 한번만 초기화가 이루어지며 프로그램이 실행될때 메모리에
            //생성되고 프로그램이 종료되어야만 메모리에서 사라지는 특징을 가지고 있습니다.

            //   Collider collider = new Collider();
            //  
            //   collider.IncreaseScore();
            //   collider.IncreaseScore();
            //   collider.IncreaseScore();
            //   collider.IncreaseScore();
            //   collider.IncreaseScore();


            #endregion


            #endregion


            #region 생성자
            //class의 인스턴스가 생성되는 시점에서 자동으로 호출되는 특수한 함수입니다.
            //생성자의 경우 객체가 생성될 때 단 한 번만 호출되며
            //생성자는 반환형이 존재하지 않기 때문에 호출되기전에는 객체에대한 메모리는
            //할당되지 않습니다.

            //  Uint unit1 = new Uint(100,"firebet");
            //  Console.WriteLine();
            //  Uint unit2 = new Uint(40, "marine");
            //  Console.WriteLine();
            //  Uint unit3 = new Uint(30, "juggling");


            #endregion


            #region 얕은 복사
            //객체를 복사할때 주소 값을 복사하여 같은 메모리를 가리키게 하는 복사 입니다.

            //  Unit unit1 = new Unit(20, "slime");
            //  unit1.Show();
            //  
            //  Console.WriteLine();
            //  
            //  Unit unit2 = unit1;
            //  unit2.Show();

            //얕은 복사의 경우 같은 객체가 서로 같은 메모리 공간을 참조하고 있기 때문에
            //하나의 객체로 값을 변경하게 되면 서로 참조된 객체도 함께 영향을 받습니다.


            #endregion


            #region 복사 생성자
            //같은 객체를 복사하여 생성시킬때 호출되는 생성자입니다.

            //  Unit skeleton1 = new Unit(30, "skeleton");
            //  Unit skeleton2 = new Unit(skeleton1);
            //  
            //  skeleton1.SetData(10);
            //  Console.WriteLine();
            //  skeleton2.SetData(20);
            //  
            //  
            //  skeleton1.Show();
            //  Console.WriteLine();
            //  skeleton2.Show();

            //복사생성자를 정의하지 않고 객체를 복사하게 되면 기본 복사 생성자가 호출되기 때문에
            //얕은 복사로 객체가 복사됩니다.

            #endregion


            #region 깊은 복사
            //객체를 복사할때 참조값이 아닌 인스턴스 자체를 새로 복사하여 서로 다른 메모리를 생성하는 복사입니다.

            //  Unit slime1 = new Unit(30, "slime");
            //  Unit slime2 = new Unit(slime1);
            //  
            //  slime1.SetData(10);
            //  slime2.SetData(20);
            //  
            //  
            //  slime1.Show();
            //  slime2.Show();








            #endregion


            #region 가비지 컬렉터
            //시스템에서 더이상 사용하지 않는 메모리를 찾은 다음 자동으로 해제하는 기법입니다.



            #endregion


            #region 프로퍼티

            //  Position position1 = new Position();
            //  
            //  position1.X = 101; //setter
            //  position1.Y = 110;
            //  
            //  Console.WriteLine("position.x : " + position1.X); //getter
            //  Console.WriteLine("position.y : " + position1.Y);

            #endregion

        }
    }
}
