namespace class_6th_function_
{
    internal class Program
    {

        static void printf(in int value)
        {
            Console.WriteLine("value의 값:" + value);
        }

        static void function(params int[] ints)
        {
            foreach (int element in ints)
            {
                Console.WriteLine("element의 값:" + element);
            }
        }

        static void position(int x = 10, int y = 10)
        {
            //기본 매개변수를 사용할때 오른쪽에서부터 기본 매개변수를 설정해주어야합니다.
            Console.WriteLine("x좌표의 값:" + x);
            Console.WriteLine("y좌표의 값:" + y);
        }

        static void start(int count)
        {
            if (count <= 0)
            {
                return;
            }

            else
            {
                start(count - 1);
            }

            Console.WriteLine("start");


        }

        static int process(int count)
        {
            if (count <= 0)
            {
                return 0;
            }

            else
            {
                return process(count - 1) + 1;

            }


        }

        static void information(object[] item)
        {
            foreach (object element in item)
            {
                Console.WriteLine(element);
            }





        }


        static void Main(string[] args)
        {
            #region in 키워드

            //  int data = 300;
            //  
            //  printf(data);



            #endregion

            #region foreach문

            //  int[] list = new int[5] { 1, 2, 3, 4, 5 };
            //  foreach(int element in list)
            //  {
            //      Console.WriteLine(element);
            //  }


            #endregion


            #region params 키워드
            //  function(10, 20, 30);
            //  function(45, 99, 1250, 9999);

            #endregion

            #region 기본 매개변수
            //  position();
            //  
            //  //기본 매개변수는 값을 넣을때 왼쪽에 있는
            //  //매개변수부터 값이 들어갑니다.
            //  
            //  position(5);

            #endregion


            #region 재귀함수
            //어떤 함수에서 자신을 다시 호출하여 작업을 수행하는 함수입니다.

            //재귀함수는 함수를 계속 호출하기 때문에 스택 영역에 메모리가
            //계속 쌓이게 되므로 스택 오버플로우가 일어 나게 됩니다.

            //  start(5);

            //  Console.WriteLine("process함수가 반환하는 값: " + process(5));

            //재귀 함수의 경우 특정한 시점에서 함수를 반환해야 하며 재귀적으로 호출한 함수는
            //스텍 프레임에 의해 마지막에 호출된 함수부터 차례대로 스택 영역에서 해제됩니다.
            #endregion

            #region 박싱과 언박싱
            //박싱은 값 형식을 참조 형식으로 변환하는 과정을 의미하며
            //언박싱은 참조 형식을 값 형식으로 변환하는 과정입니다.

            //  int attack = 10;
            //  object box = attack;
            //  
            //  Console.WriteLine("box의 값:" + box);
            //  
            //  int result = (int)box;

            //  object[] datalist = new object[5];
            //  
            //  datalist[0] = 10;      //attack;
            //  datalist[1] = "marine";//name
            //  datalist[2] = 55.5f;   //health
            //  
            //  information(datalist);
            #endregion



        }
    }
}
