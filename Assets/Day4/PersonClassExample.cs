using UnityEngine;

public class PersonClassExample : MonoBehaviour
{
    private void Start()
    {
        // 자료형 변수명 = 값
        // 클래스 클래스명 = new 클래스

        Chair chair1 = new Chair();
        Chair chair2 = new Chair();
        
        chair2.Color = "푸른색";
        
        // ---

        // Person person1 = new Person();
        //
        // person1.Name = "김상곤";
        // person1.Age = 18;
        // person1.Height = 182.7f;
        // person1.Weight = 78;
        // person1.HasGlasses = false;

        // 생성자를 만든 이후의 person1 선언
        Person person1 = new Person("김상곤", 18, 182.7f, 78, false);
        
        // 현실에서는 불가능
        // 변수가 public인 경우 수정 가능, private로 바뀌면서 수정 불가능
        // Debug.Log(person1.Name);
        // person1.Name = "황상곤";
        Debug.Log(person1.HasGlasses);
        
        person1.Introduce();
        person1.Run();
        person1.SeatDown(chair1);
        
        // ---

        // Person person2 = new Person();
        //
        // person2.Name = "김예찬";
        // person2.Age = 19;
        // person2.Height = 187.7f;
        // person2.Weight = 81;
        // person2.HasGlasses = true;
        
        // 생성자를 만든 이후의 person2 선언
        Person person2 = new Person("김예찬", 19, 187.7f, 81, true);
        
        person2.Introduce();
        person2.Run();
        person2.SeatDown(); //person2.SeatDown(chair2);
        person2.Punch(person1);
        
        // ---

        // null이란, 존재하지 않는다는 뜻
        // 객체지향 프로그래밍에서 제임스 고슬링이 땅을 치고 후회하는 문법 중 하나
        // 가장 빈번하게 오류를 일으키는 문법
        Person person3 = null; // 메모리 주소를 가리킬 변수만 만들었지 알맹이는 존재하지 않음
    }
}
