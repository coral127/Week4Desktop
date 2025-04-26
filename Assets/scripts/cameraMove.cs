using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;     // ���� ��� (������ Player)
    public Vector3 offset;       // ��ġ ������ (ī�޶� �ణ ������ ���̰� ���)
    public float smoothSpeed = 0.125f;  // �ε巴�� ���󰡱� ���� �ӵ�

    void LateUpdate()
    {
        Vector3 desiredPosition = Player.position + offset;   // ��ǥ ��ġ
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}