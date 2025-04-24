using System.ComponentModel.Design;
using System.Reflection;

namespace Test
{
    class Program
    {
        //답지
        static void Main(string[] args)
        {
            int x = 1;
            for (x = 1; x < 11; x++)
            {
                Console.WriteLine($"문제 {x}번");
                Answer(x);
            }
        }


        //1번 문제
        static int Sum(int[] arr)
        {


            // TODO : 배열의 모든 요소의 합을 계산하는 코드 작성
            int index = 0;
            int Sum = 0;
            for (index = 0; index < arr.Length; index++)
            {
                Sum += arr[index];
            }
            return Sum;
        }


        //문제 2번

        private static void Add(int i, int result)
        {
            result += i;
        }

        static void Answer(int x)
        {
            if (x == 1)
            {
                int[] ints = { 3, 6, 7, 9 };
                Console.WriteLine(Sum(ints));
            }
            else if (x == 2)
            {
                int total = 10;
                Console.WriteLine(total); //10
                Add(200, total); //200+total
                Console.WriteLine(total); //210
            }
            else if (x == 3)
            {
                Console.WriteLine("서로 다른 클래스인데 Area()의 접근제한자가 private이기 때문이다. public으로 바꾸면 된다.");

            }
            else if (x == 4)
            {
                Console.WriteLine("출력되는 x=10");
                Console.WriteLine("x += x* ++y에서, 처음에는 2였던 x의 값이 x+=2*4 가 되어 10이 된다. 그리고 Console.WriteLine(x++)가 끝나고 난 다음 시점에서, x는 11이 된다.");
            }
            else if (x == 5)
            {
                while (true)
                {
                    Console.WriteLine("숫자를 입력하세요.");
                    string answer = Console.ReadLine();

                    bool isSuccess = int.TryParse(answer, out int result);

                    // TODO : 입력받은 정수가 홀수인지 짝수인지 구분하는 코드 작성하기

                    if (isSuccess)
                    {
                        int Judge = result % 2; //나머지가 0이면 짝, 1이면 홀
                        if (Judge == 0) Console.WriteLine("짝수입니다.");
                        else Console.WriteLine("홀수입니다.");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (x == 6)
            {
                int[] intArr = { 4, 7, 2, 5, 6, 8, 3 };
                int n = 0;


                foreach (int i in intArr)
                    Console.Write(i + " ");
                Console.WriteLine("");
            }
            else if (x == 7)
            {
                Console.WriteLine("네발로 걷기가 출력된다. \nZerg.Move(); 실행하기 위해 생성된 것은 Unit클래스를 상속 받은 Zergling 클래스 이며, 해당 클래스에 할당된 Move()를 읽게 된다. \n그러므로 Zergling 클래스의 Move()에 override된 \"네발로 걷기\"라는 결과 값을 출력한다.");
            }

            else if (x == 8)
            {
                Console.WriteLine("DFS: 1>3>6>9");
                Console.WriteLine("BFS: 1>2>5>4>8>");
            }
            else if (x == 9)
            {
                Stack<int> stack = new Stack<int>();

                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Pop();

                stack.Push(4);
                stack.Push(5);

                while (stack.Count > 0)
                    Console.WriteLine(stack.Pop());

                Console.WriteLine("2, 5, 4, 1");
            }
            else if (x == 10)
            {

            }

        }
    }
}
