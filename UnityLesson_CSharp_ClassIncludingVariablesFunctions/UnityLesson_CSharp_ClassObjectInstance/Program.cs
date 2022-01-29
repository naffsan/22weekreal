using System;

namespace UnityLesson_CSharp_ClassObjectInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AA 객체 생성
            //new 키워드
            new AA();
            //AA클래스의 AA함수, 생성자: 클래스명과 같은 함수, 객체를 생성하고 반환하는 함수

            //↓이걸 인스턴스화라고 함
            //=메모리 공간에 객체를 할당한다
            //new AA()로 생성된 객체를 반환한 값(객체)이 AA타입 변수 aa에 할당되었다-여기선 new 키워드로 호출한 것이 객체
            //이렇게 하면  aa변수를 통해 생성된 객체에 접근 가능해짐
            //=사람 클래스한테 접근해서 이름한번 말해봐 할 때 그 접근
            //여기서 새로 생성된 객체가 할당된 aa변수를 인스턴스라고 함
            AA aa = new AA(); //AA 클래스타입의 aa 생성, 이 반환값을 집어넣어야 쓸 수 있다
            //bool tmpIsFinished = PrintSomethingAndReturnFinished("내용");와 같다고 보면 됨
        }
    }
    //AA 클래스
    //접근 제한자
    //public: 다른 모든 클래스에서 접근 가능
    //private: 다른 클래스에서 접근 불가능
    //protected: 상속받은 클래스에서만 접근 가능-------------
    //internal: 같은 어셈블리(같은 프로젝트)에서만 접근 가능-이런게 있다는 것 정도만 아세요
    //기본적으로 접근제한자를 명시하지 않으면 private가 디폴트
    public class AA
    {

    }
}
