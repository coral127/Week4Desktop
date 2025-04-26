using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;     // 따라갈 대상 (보통은 Player)
    public Vector3 offset;       // 위치 오프셋 (카메라가 약간 위에서 보이게 등등)
    public float smoothSpeed = 0.125f;  // 부드럽게 따라가기 위한 속도

    void LateUpdate()
    {
        Vector3 desiredPosition = Player.position + offset;   // 목표 위치
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}