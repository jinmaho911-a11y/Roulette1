using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도 변수
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 클릭하면 회전 속도를 설정해주면??
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = Random.Range(10,20); // 클릭하면 회전 속도를 10으로 설정
        }

        if(rotSpeed < 0.001f)
        {
            rotSpeed = 0;
        }
        else // 회전 속도만큼 룰렛을 회전시킨다
            transform.Rotate(0, 0, rotSpeed);

        rotSpeed *= 0.96f; // 회전 속도를 점점 줄여서 멈추게 한다

    }

}
