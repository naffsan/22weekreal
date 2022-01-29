using System;

namespace UnityLesson_CSharp_InstantiationOfObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person person1=new Person();//접근하는 지역변수 생성: 클래스명을 갖다쓰고 new 클래스명 하면 생성!
            //점 연산자=멤버 변수, 메서드(함수) 등에 접근하는 연산자
            person1.age = 18;//사람1의 변수 초기화
            person1.height = 175f;
            person1.name = "카논";
            person1.gender = '여';
            person1.isresting = true;
            //객체의 멤버함수 호출
            person1.SayAll_info();
           
            Person person2=new Person();
            person2.age = 17;
            person2.height = 178f;
            person2.name = "베니스";
            person2.gender = '남';
            person2.isresting = false;
            person2.SayAll_info();
        }
        //메서드, 클래스, 변수 모두 퍼블릭 등을 붙여 접근제한 가능
        public class Person
        {
            //멤버 변수
            public int age;
            public float height;
            public bool isresting;
            public char gender;
            public string name;

            public void SayAll_info()
            {
                SayAge();
                SayHeight();
                SayIsresting();
                SayGender();
                SayName();
            }
            //
            public void SayAge()
            {
                Console.WriteLine($"{name}의 나이: {age}" ) ;
                //writelone은 함수, 이걸 호출하면 콘솔 창에 변수가 출력된다

            }

            public void SayHeight()
            {

                Console.WriteLine($"{name}의 키: {height}");

            }
            public void SayGender()
            {
                Console.WriteLine($"{name}의 성별: {gender}");

            }
            public void SayIsresting()
            {
               

                Console.WriteLine($"{name}의 휴식 여부: {isresting}");
                if (isresting)
                {
                    isresting = true;
                    Console.WriteLine($"{name}은/는 쉬는 중!");
                }
                else
                {
                    Console.WriteLine($"{name}은/는 활동 중!");
                }

            }
            public void SayName()
            {

                Console.WriteLine($"이름: {name}");
            }
        }
    }

}
