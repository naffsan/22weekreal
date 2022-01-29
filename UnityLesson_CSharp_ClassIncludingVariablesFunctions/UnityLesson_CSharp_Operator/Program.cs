using System;

namespace UnityLesson_CSharp_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //산술 연산 
            int a = 14;
            int b = 5;
            int c = 0;
            //==============================================================================
            // 더하기
            c = a + b;
           
            //빼기
            c = a - b;
           
            //나누기->int면 나머지는 버림
            c = a / b;
           
            //곱하기
            c = a * b;
            
            //나머지->실수형이어도 정수로 변환시킴
            c = a % b;

            //증감 연산
            //증가 연산자, 감소 연산자
            //==============================================================================
            //증가 연산자
            c++;//c=c+1;과 같다
            //감소 연산자
            c--;//c=c-1;
            Console.WriteLine(c);

            //관계 연산
            //수학에서의 등호, 부등호-같음, 다름, 크기 비교 연산 수행
            //관계연산 결과가 참이면 true 아니면 false 반환
            //==============================================================================
            bool result;
            //같음 비교
            result = a==b;
            Console.WriteLine(result);
            //다름 비교
            result = a!=b;
            Console.WriteLine(result);
            //크다
            result = a>b;
            Console.WriteLine(result);
            //작다
            result = a < b;
            Console.WriteLine(result);
            //작거나 같다
            result = a <= b;
            Console.WriteLine(result);
            //또는 Console.WriteLine(a <= b);
            Console.WriteLine("여기부터 논리연산");
            //논리 연산(논리 자료형 연산-bool형식)
            //양측의 피연산자들을 비교해서 연산 수행
            //or and xor not
            //==============================================================================
            //or
            //a b 둘중 하나라도 참이면 true, 아니면 false
            bool A=true;
            bool B=false;
            result = A | B;
            Console.WriteLine(result);
            //and
            //a, b 둘 다 참이어야 true, 아니면 false
            result = A & B;
            Console.WriteLine(result);
            //xor
            //a, b 둘중 하나만 참일 때만 true 반환, 나머지는 false
            result = A ^ B;
            Console.WriteLine(result);
            //not
            //a의 반대 부호 반환(true면 false, false면 true 반환)
            result = !A;
            Console.WriteLine(result);

            //조건부 논리연산
            //왼쪽 피연산자 조건에 따라 오른쪽 피연산자와 비교할지 말지 평가 후에 연산
            //conditional or(결과는 같음)
            //A가 true면 B 값 관계없이 true이므로 연산 필요 없이 반환, 최적화용 코드
            result = A || B;
            // conditional and
            //A가 false이면 B값에 관계없이 False이므로 연산하지 않고 값을 반환한다
            result = A && B;

            //비트 연산
            //이유: 데이터를 효율적으로 관리하기 위함
            //or and xor not shift-left, shift-right
            //==============================================================================

            int howManyBitsYouWantToShift = 3;
            //or
            c = a|b;
            Console.WriteLine(c);
            //and
            c = a&b;
            //xor
            c = a ^ b;
            //not
            c = ~a;
            Console.WriteLine(c);
            //shift-left
            c = a << howManyBitsYouWantToShift;
            Console.WriteLine(c);
            //shift-right
            c = a >> howManyBitsYouWantToShift;
            Console.WriteLine(c);
        }
    }//FSM은 Finite state machine, 유한상태머신
    //클래스의 상태에 따라 다른 동작을 하기 위해 사용하는 패턴
    //ex_플레이어가 IDLE일 때 귀환 누르면 귀환 시작하나 피격, 공격상태일때는 불가능한 조건을 아래 플레이어 상태에 따라 나눔
    [Flags]
    public enum e_FSM
    {
        IDLE=0,
        피격당한상태=1<<0,
        공격중인상태=1<<1,
    }
}
