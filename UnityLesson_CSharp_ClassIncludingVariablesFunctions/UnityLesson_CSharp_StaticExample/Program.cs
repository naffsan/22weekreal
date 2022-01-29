using System;

namespace UnityLesson_CSharp_StaticExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Villain villain1 = new Villain();
            villain1.age = 124;
            villain1.name = "헤스터";
            villain1.height = 157f;
            villain1.gender = '?';
            villain1.isresting = false;
           
            villain1.Jump();
            villain1.Smash();

            Villain.typeName = "빌런";
            Villain.SayTypeName();//static은 이렇게 호출해야 함, 각 인스턴스가 아니라 클래스를 통째로 참조해야


        }


    }
    public class Villain
    {
        static public string typeName;//
        public int age;
        public float height;
        public bool isresting;
        public char gender;
        public string name;

        static public void SayTypeName()//
        {
            Console.WriteLine(typeName);//static-static함수, 변수만
        }
        public void SayAll_info()
        {
            Jump();
            Smash();
            SayAge();
            SayHeight();
            SayIsresting();
            SayGender();
            SayName();
        }

        public void Jump()
        {
            Console.WriteLine($"{name}(이)가 점프했다!");

        }
        public void Smash()
        {
            Console.WriteLine($"{name}(이)가 무기를 휘둘렀다!");

        }
        public void SayAge()
        {
            Console.WriteLine($"{name}의 나이: {age}");
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
    static public class Person
    {  
    }
}
