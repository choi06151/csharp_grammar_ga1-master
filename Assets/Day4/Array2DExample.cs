using UnityEngine;

public class Array2DExample : MonoBehaviour
{
    private void Start()
    {
        // 2차원 배열 (다차원 배열)
        // 게임 개발에서 2차원 배열은 주로 타일 기반 게임에서 사용된다.
        // 사용 예시 : '3match 퍼즐 게임, 플랫포머 맵, 인벤토리, 체스'처럼 표 형태의 데이터를 표현하는 데 많이 사용

        int[,] enemyHealths = new int[2, 3]; // -> [200, 300]인 경우를 생각해보자.
        enemyHealths[0, 0] = 31;
        enemyHealths[0, 1] = 28;
        enemyHealths[0, 2] = 45;
        enemyHealths[1, 0] = 10;
        enemyHealths[1, 1] = 56;
        enemyHealths[1, 2] = 68;
        
        Debug.Log(enemyHealths[1, 1]);
        
        // [1] 배열은 행우선으로 접근을 해야한다. (캐시 히트를 위해서)
        for (int col = 0; col < enemyHealths.Length; col++)
        {
            for (int row = 0; row < enemyHealths.Length; row++)
            {
                Debug.Log($"enemyHealths[{col}][{row}] : {enemyHealths[col, row]}");
            }
        }
        
        // [2]
        for (int row = 0; row < enemyHealths.Length; row++)
        {
            for (int col = 0; col < enemyHealths.Length; col++)
            {
                Debug.Log($"enemyHealths[{col}][{row}] : {enemyHealths[col, row]}");
            }
        }
        
        // [1]과 [2]는 성능 차이가 있다.
        // 이유 : 메모리는 물리적으로 가로로 길게 변수가 저장되기 때문에 [1]은 순서대로 접근을 하고, [2]는 왔다갔다 하기 때문이다.
        // [1]이 [2]보다 빠른 이유는 페이징이나 세그먼테이션을 이용하여 미리 주변 변수들까지 캐싱해놓게 되기 때문이다.
        // ([2]는 캐시 미스가 나타나게 된다.)
    }
}
