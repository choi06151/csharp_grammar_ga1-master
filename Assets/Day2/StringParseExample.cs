using UnityEngine;

public class StringParseExample : MonoBehaviour
{
    void Start()
    {
        // 문자열을 int로 변환
        string stringAge = "38";
        int intAge = 0;
        bool result1 = int.TryParse(stringAge, out intAge);
        if (result1)
        {
            Debug.Log(intAge);
        }
        else
        {
            Debug.Log("변환에 실패했습니다.");
        }
        
        // 문자열을 float로 변환
        string stringWeight = "70.2kg";
        float floatWeight = 0f;
        bool result2 = float.TryParse(stringWeight, out floatWeight);
        if (result2)
        {
            Debug.Log(floatWeight);
        }
        else
        {
            Debug.Log(floatWeight);
            Debug.Log("변환에 실패했습니다.");
        }

        // float을 문자열로 변환
        float floatHeight = 174f;
        string stringHeight = floatHeight.ToString();
        stringHeight += "cm";
        Debug.Log(stringHeight);
    }
}
