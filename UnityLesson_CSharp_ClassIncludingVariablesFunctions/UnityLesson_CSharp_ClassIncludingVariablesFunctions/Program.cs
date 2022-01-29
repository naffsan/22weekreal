using System;

namespace UnityLesson_CSharp_ClassIncludingVariablesFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        //camel case: 낙타의 등 형태의 패턴으로 글씨를 작성한다, 글을 쓰는 규칙(대소문자 구분)
        //단어가 바뀔 때 첫 문자는 대문자로 처리
        //변수는 소문자로 시작, 클래스나 메서드, 네임스페이스 등은 대문자로 시작함

        //코드 작성 시 유의사항
        //1. 줄임말은 되도록 사용ㄴㄴ
        //2. 이름을 보았을 때 어떤 기능이나 목적인지 알 수 있도록 선정
        //3. 애매하거나 복잡한 내용이 있으면 주석을 단다
        //4. 띄어쓰기할 때는 _쓰기

        //클래스 정의 형태
         class 클래스명
        {
           // 멤버 변수(키, 몸무게, 나이, 성별...)
           // 멤버 함수
        }
        class Person
        {
            //멤버 변수
            int age;
            float height;
            bool isresting;
            char gender;
            string name;
            
            void SayAllinfo()
            {
                SayAge();
                SayHeight();
                SayIsresting();
                SayGender();
                SayName();
            }
            //
            void SayAge()
            {
                Console.WriteLine(age);
                //writelone은 함수, 이걸 호출하면 콘솔 창에 변수가 출력된다
               
            }

            void SayHeight()
            {
    
                Console.WriteLine(height);
                
            }
            void SayGender()
            {
                Console.WriteLine(gender);
                
            }
            void SayIsresting()
            {
                
                Console.WriteLine(isresting);
               
            }
            void SayName()
            {
                
                Console.WriteLine(name);
            }
        }
    }

}
