namespace class_5th_arraygement_
{
    internal class Program
    {
        static void Calculator()
        {
            Console.WriteLine("계산");
        }

        static int damage()
        {
            int damage = 10;

            return damage;
        }

        static void Recovery(int health)
        {
            Console.WriteLine("health의 값:" + health);
        }



        struct Unit
        {

            #region 접근 지정자

            //구조체 내부에 포함되어 있는 속성에 접근 범위를 제한하는 지정자 입니다.

            //private
            //구조체 내부에서만 접근을 허용하며 구조체 외부 또는 자기가 상속하고 있는
            //구조체에서는 접근을 허용할 수 없는 지정자입니다.

            //protected
            //구조체 내부와 자기가 상속하고 있는 구조체에서 접근을 허용하며
            //구조체 외부에서는 접근을 허용하지 않는 접근지정자입니다.

            //pubilc
            //구조체 내부와 자기가 상속하고있는 구조체 그리고 구조체 외부에서도
            //접근을 허용하는 지정자입니다.

            #endregion

            public
            char grade;
            public
            int health;
            public
            float attack;
        }
        static void Main(string[] args)
        {
            #region 배열
            //같은 자료형의 변수들로 이루어진 유한 집합입니다.

            //  int []arr = new int[5];
            //  
            //  arr[0] = 10;
            //  arr[1] = 20;
            //  arr[2] = 30;
            //  arr[3] = 40;
            //  arr[4] = 50;
            //  
            //  int i = 0;
            //  
            //  for(i=0;i<=4;i++)
            //  {
            //      Console.WriteLine(arr[i]);
            //  }

            //배열의 경우 첫번째 원소는 0부터 시작합니다.



            #endregion

            #region 최대값과 최솟값


            //  int[] arr = new int[] { 10, 57, 7, 1, 5 };
            //  
            //  int max = arr[0];
            //  int min = arr[0];
            //  
            //  
            //  
            //  int i = 0;
            //  
            //  for(i = 0; i<=4; i++)
            //  {
            //      if (arr[i]>max)
            //      {
            //          max = arr[i];
            //      }
            //  
            //      if (arr[i]<min)
            //      {
            //          min = arr[i];
            //  
            //      }
            //  
            //      
            //  }
            //  
            //  Console.WriteLine(max);
            //  Console.WriteLine(min);

            #endregion


            #region 메모리 구조

            #region CODE 영역
            //실행할 프로글매의 코드가 저장되는 영역이며 CPU는 코드영역에서
            //저장된 명령을 하나씩 가져와서 처리하게 됩니다.
            //프로그램이 시작하고 종료될때까지 메모리에 남아있는 특징을 가지고 있습니다.
            #endregion

            #region DATA 영역

            //전역변수와 정적변수가 저장되는 영역으로 프로그램의 시작과 함께 할당되며
            //프로그램이 종료될때 까지 메모리에 남아있는 특징을 가지고 있습니다.

            #region STACK 영역

            //프로그램이 자동으로 사용하는 임시 메모리 영역이며 함수 호출시 생성되는
            //지역변수와 매개 변수가 저장되는 영역입니다.
            //함수의 호출이 끝나면 메모리에서 사라지는 특징을 가지고 있습니다.
            //스텍영역에 저장되는 함수의 호출정보를 스텍 프레임이라고 합니다.

            #region HEAP 영역
            //사용자가 직접 메모리 공간을 할당하고 해제하는 메모리 영역입니다.


            #endregion


            #endregion

            #endregion
            #endregion

            #region 문자열
            //연속적인 메모리 공간에 저장된 문자 변수의 집합입니다.

            //문자열은 공백도 함께 메모리 공간에 포함하여 크기가 결정되며
            //마지막에는 문자열의 끝을 알려주는 제어문자가 추가됩니다.(NULL문자)

            //문자열의 경우 서로 연속적인 메모리 공간으로 연결되어 있지만 문자 배열 사이에
            //무효의 문자를 넣게 되면 무효의 문자까지만 문자열을 출력합니다.

            //  string name = "marine";
            //  
            //  Console.WriteLine(name);
            //  
            //  name = "mar\0ine";
            //  
            //  Console.WriteLine(name);

            #endregion


            #region 구조체

            //여러개의 변수를 하나의 집합으로 구조화한 다음 하나의 객체를 생성하는것입니다.

            //  Unit unit;
            //  
            //  unit.grade = 'S';
            //  unit.health = 100;
            //  unit.attack = 15.5f;
            //  
            //  Console.WriteLine(unit.grade);


            //구조체를 선언하기전에 구조체는 메모리 공간이 생선되지 않으므로
            //구조체 내부에 있는 데이터를 초기화할 수 없습니다.

            #endregion

            #region 함수
            //하나의 특별한 목적의 작업을 수행하기 위해 독립적으로 설계된 코드의 집합입니다.

            //  Calculator();
            //  
            //  Console.WriteLine("damage함수가 반환하는 값:" + damage());



            //함수의 경우 자료형과 반환하는 값의 형태가 일치하지 않으면 원하는 값을 얻을 수 없습니다.

            #endregion

            #region 매개 변수
            //함수의 정의에서 전달받은 인수를 함수 내부로 전달하기 위해 사용하는 변수입니다.

            //  int hp = 100;
            //  
            //  Recovery(hp);

            //매개변수는 함수 내부에서만 연산이 이루어지며
            //함수가 종료되면 메모리에서 사라지는 특징을 가지고 있습니다.

            #endregion
        }
    }
