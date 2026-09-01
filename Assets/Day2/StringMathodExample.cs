using UnityEngine;

public class StringMathodExample : MonoBehaviour
{
    void Start()
    {
        // 문자열은 문자열만의 여러 가지 속성과 기능을 가지고 있다.
        // 서식, 길이, 탐색, 변형, 문할
        
        // 길이 속성
        string name = " 황금독수리 새상을 놀라게 하다.   ";
        Debug.Log(name.Length);
        
        // 탐색 기능 : 문자열 안에서 특정 문자열이 있는지 없는지, 있다면 어디인지 등등을 알 수가 있다.
        int index = name.IndexOf("놀");
        Debug.Log(index);

        bool isHwang = name.StartsWith("황");
        Debug.Log(isHwang);

        bool isContainEagle = name.Contains("독수리");
        Debug.Log(isContainEagle);
        
        // 변형 기능 : 대소문자 변환 혹은 추가, 대체, 삭제
        name = name.Trim();                       // 양쪽 공백 제거 (TrimStart, TrimEnd 등도 있음)
        name = name.Insert(6, "온");      // 중간 삽입
        name = name.Remove(name.IndexOf('.'));    // 문자 삭제
        name = name.Replace("새", "세");           // 문자 변환
        Debug.Log(name);

        string name2 = "Karina";
        name2 = name2.ToUpper();                  // 대문자로 변형
        Debug.Log(name2);
        name2 = name2.ToLower();                  // 소문자로 변형
        Debug.Log(name2);
        
        // string : 2 * (문자열의 길이) 바이트
        // => 문자열은 불변식이므로 문자가 수정될 때마다 새로 메모리를 할당한다.
        //    따라서 문자열 변환 코드는 최소화 해야 한다.
    }
}
