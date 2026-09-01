using UnityEngine;

public class Person
{
    // 속성 (C# : 필드, C++ : 멤버) (변수)
    
    // 접근 제한자 (public, private, protected, internal)
    // - public  : 외부에서 접근(읽기, 쓰기)가 가능하다.
    // - private : 외부에서 접근이 불가능하다.
    
    // 추상화 -> 은닉화(숨길 건 숨긴다.) -> 캡슐화
    
    private string _name   = string.Empty; // = "" // (1) 필드 변수
    private int    _age    = 0;
    private float  _height = 0f;
    private double _weight = 0d;
    public  bool   HasGlasses = false;

    // 생성자 메서드
    // - 객체가 생성될 때 new 키워드와 함께 호출하는 메서드
    // - 클래스 이름과 같아야 한다.
    /*
     * public 클래스명()
     * {
     * }
     */
    public Person(string name, int age, float height, double weight, bool hasGlasses) // (2) 매개 변수
    {
        int myFatherAge = 34; // (3) 지역 변수
        
        _name   = name;
        _age    = age;
        _height = height;
        _weight = weight;
        HasGlasses = hasGlasses;
    }
    
    // 기능 (C# : 메서드) (함수)
    public void Introduce()
    {
        Debug.Log($"안녕하세요. 제 이름은 {_name}이고, 나이는 {_age}입니다. " +
                  $"키와 몸무게는 ({_height}cm/{_weight}kg) 입니다.");
    }

    public void Run()
    {
        Debug.Log($"[{_name} 뛰는 중!] 속도 : {100 - (_height /_weight)}");
    }
    
    // 메서드 오버로딩 : 같은 이름의 메서드를 중복하여 여러 개 만드는 것
    // - 매개 변수의 개수나 자료형이 달라야 한다.
    
    public void SeatDown()
    {
        Debug.Log("땅바닥에 앉는다!");
    }

    public void SeatDown(Chair chair)
    {
        Debug.Log($"{chair.Color} 의자에 앉는다.");
    }

    public void Punch(Person otherPerson)
    {
        //string Name = "아자카라쵸!"; // 변수 쉐도잉
        //Debug.Log($"{_name}이가 {otherPerson._name}이를 때렸다!");    // 아자카라쵸!이가 김상곤이를 때렸다!
        //Debug.Log($"{this.Name}이가 {otherPerson.Name}이를 때렸다!"); // 김예찬이가 김상곤이를 때렸다!
        
        Debug.Log($"{_name}이가 {otherPerson._name}이를 때렸다!");      // 김예찬이가 김상곤이를 때렸다!
        
        // 하지만, this를 사용은 줄여야 한다.
        // - public  필드 변수 : Name  (파스칼)
        // - private 필드 변수 : _name (_카멜)
        // -         지역 변수 : name  (카멜)
    }
}