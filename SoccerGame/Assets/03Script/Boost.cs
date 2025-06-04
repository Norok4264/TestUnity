using UnityEngine;

public class Boost : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BluePlayer") || other.CompareTag("RedPlayer"))
        {
            // moveSpeed 속성 있는 PlayerMovement 컴포넌트 가져오기
            var movement = other.GetComponent<MonoBehaviour>();

            if (movement != null) 
            {
                var type = movement.GetType();
                var field = type.GetField("moveSpeed");

                if (field != null) // moveSpeed field가 존재한다면
                {
                    field.SetValue(movement, 20f); // moveSpeed 20으로 증가
                }
            }

            Destroy(gameObject); // Boost 오브젝트 제거
        }
    }
}
