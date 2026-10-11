using UnityEditor;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 0; // 회전 속도 변수
    bool isRotating = false; // 회전 중인지 여부를 나타내는 변수
    Quaternion m_LocalRotation; // 로컬 회전 변수
    void Start()
    {
        transform.Rotate(0, 0, Random.Range(45f, 300f)); // 클릭하면 룰렛을 랜덤한 각도로 회전시킨다  
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        { 
            isRotating = true;
        }
       
        else if (rotSpeed > 0)
        {
            Input.ResetInputAxes(); // 회전 중에는 클릭을 무시한다
        }
        else if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = Random.Range(10, 30); // 클릭하면 회전 속도를 10에서 19사이로 랜덤하게 설정해준다
        }
        else if (rotSpeed >= 0.9f)
        {
            rotSpeed *= 0.9f;
        }
        



        // 클릭하면 회전 속도를 설정해주면


        // 회전 속도만큼 룰렛을 회전시킨다
        transform.Rotate(0, 0, rotSpeed);

        if (isRotating == true)
        {
            rotSpeed *= 0.99f;
        }
        if (rotSpeed == 0f)
        {
            isRotating = false;
        }

        // 회전 속도를 점점 줄여서 멈추게 한다

        if (rotSpeed <= 0.01f)
        {
            rotSpeed = 0; // 회전 속도가 0.1보다 작으면 회전을 멈춘다
        }

    }
       
}

//float 랜덤 할때 float mlninclusive, float maxinclusive)이 1.0f, 10.0f면 1~10 사이 int 랜덤할때면 1,11이 1~10사이
