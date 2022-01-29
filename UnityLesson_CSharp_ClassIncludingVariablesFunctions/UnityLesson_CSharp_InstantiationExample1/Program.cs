using System;

namespace UnityLesson_CSharp_InstantiationExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.name = "상급오크";
            orc1.height = 240.2f;
            orc1.weight = 200f;
            orc1.age = 140;
            orc1.gender = '♂';
            orc1.isresting = false;
            orc1.All();

            Orc orc2 = new Orc();
            orc2.name = "하급오크";
            orc2.height = 140.4f;
            orc2.weight = 120f;
            orc2.age = 60;    
            orc2.gender = '♀';
            orc2.isresting = true;
            orc2.All();
        }
        public class Orc
        {
            public string name;
            public float height;
            public float weight;
            public int age;
            public char gender;
            public bool isresting;

         public void All()
            {
                Name();
                Height();
                Weight();
                Age();
                Gender();
                IsResting();

            }

         public void Name()
            {
                Console.WriteLine($"이름: {name}");
            }
        public void Height()
            {
                Console.WriteLine($"키: {height}");

            }
            public void Weight()
            {
                Console.WriteLine($"몸무게: {weight}");
            }
            public void Age()
            {
                Console.WriteLine($"나이: {age}");
            }
            public void Gender()
            {
                Console.WriteLine($"성별: {gender}");

            }
            public void Jump()
                { Console.WriteLine($"{name}(이)가 점프했다!");
            }
            public void Smash()
            {
                Console.WriteLine($"{name}(이)가 무기를 휘둘렀다!");
            }
            public void IsResting()
            {
                if (isresting)
                {
                    isresting = true;
                    Jump();
                    Smash();
                }
                //이걸 if(orc1.isresting)로 해도 됨
                else
                {
                    Console.WriteLine($"{name}(이)가 바쁘다.");
                }
                
            }
        }
    }

}
