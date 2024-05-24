namespace class_9th_random_
{
    public class Computer : IMouse, IKeyboard
    {

        public void Input()
        {
            Console.WriteLine("m");
        }


        public void Select()
        {
            Console.WriteLine("s");
        }


    }


    abstract public class Vehicle
    {

        private string name;
        private float speed;


        abstract public void Move();



    }


    public class Bicycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Bicycle Move");
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Motorcycle Move");
        }
    }


    public interface IMouse
    {
        public void Select();
    }

    public interface IKeyboard
    {
        public void Input();
    }











    internal class Program
    {

        public delegate void Calculator(int x, int y);//델리게이트의 선언

        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Min(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void Gob(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static void Na(int x, int y)
        {
            Console.WriteLine(x / y);
        }



        static void hp(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("★");
            }
        }



        static void Main(string[] args)
        {

            #region 랜덤함수


            //  Random rnadom = new Random();
            //  
            //  int num = rnadom.Next(1, 100);
            //  
            //  Console.WriteLine("num의 값: " + num);


            #endregion




            #region Up Dwon


            //  int num2 = 0;
            //  int max = 50;
            //  int min = 1;
            //  int count = 5;
            //  
            //  Random rnadom = new Random();
            //  
            //  int num = rnadom.Next(min, max);
            //  
            //  while (true)
            //  {
            //      
            //  
            //      Console.WriteLine("숫자의 범위 1~50");
            //      hp(count);
            //  
            //      num2 = Convert.ToInt32(Console.ReadLine());
            //  
            //  
            //  
            //  
            //      if (num2 > num)
            //      {
            //          Console.WriteLine("입력한 값이 컴퓨터의 값보다 큽니다.");
            //          count = count - 1;
            //  
            //          if (count == 0)
            //          {
            //              Console.WriteLine("실패하였습니다.");
            //              Environment.Exit(1);
            //          }
            //          continue;
            //  
            //      }
            //  
            //      else if (num2 < num)
            //      {
            //          Console.WriteLine("입력한 값이 컴퓨터의 값보다 작습니다.");
            //          count = count - 1;
            //  
            //          if (count == 0)
            //          {
            //              Console.WriteLine("실패하였습니다.");
            //              Environment.Exit(1);
            //          }
            //          continue;
            //      }
            //  
            //      else if (num2 == num)
            //      {
            //          Console.WriteLine("정답입니다.");
            //          Environment.Exit(1);
            //      }
            //  
            //  
            //      break;
            //  
            //  }





            #endregion



            #region ASCII 코드
            //미국 국가표준 협회에서 표준화한 정보 교환용 7bit 부호체계입니다.


            //문자 인코딩
            //복잡한 신호를 0과 1의 디지털 신호(2진수)로 변환하는 것입니다. 

            //  char alphabet = 'A';
            //  
            //  for(int i =65; i<91; i++)
            //  {
            //      Console.Write((char)i+" ");
            //  }






            #endregion




            #region 추상 클래스
            //추상함수를 선언한다음 상속을 통해 하위 클래스에서 함수를 완성하도록 유도하는 클래스입니다.

            //  Vehicle vehicle = new Vehicle();

            //추상클래스는 인스턴스를 할수 없습니다.

            //  Bicycle bicycle = new Bicycle();
            //  
            //  bicycle.Move();
            //  
            //  Motorcycle motorcycle = new Motorcycle();
            //  
            //  motorcycle.Move();

            #endregion



            #region 인터 페이스
            //  Computer computer = new Computer();
            //  
            //  computer.Select();
            //  computer.Input();



            #endregion


            #region 대리자(델리 게이트)
            //함수의 주소값을 저장한 다음 함수를 대신 호출하는 기능입니다.

            //대리자는 함수의 반환형과 매개 변수의 타입이 일치해야 합니다.

            //   Calculator calculator;
            //   
            //   calculator = Add;
            //   
            //   calculator(10, 20);
            //   
            //   calculator = Min;
            //   
            //   calculator(20, 10);
            //   
            //   calculator = Gob;
            //   
            //   calculator(2, 5);
            //   
            //   calculator = Na;
            //   
            //   calculator(10, 2);
            #endregion



            #region 델리게이트 체인
            //하나의 호출자에 여러개의 함수를 등록해서 사용하는 기법입니다.

            //  Calculator calculator;
            //  
            //  calculator = Add;
            //  calculator += Min;
            //  calculator += Gob;
            //  calculator += Na;
            //  
            //  calculator(5, 5);
            //  
            //  Console.WriteLine("-------------------------------------------------------------");
            //  
            //  calculator -= Na;
            //  
            //  calculator(10, 2);

            #endregion

        }
    }
}
