using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    void Update()
    {
        // 1.MoveTowards
        /*
        transform.position =
            Vector3.MoveTowards(transform.position, target, 1f);   //��ӿ (������ġ, ��ǥ��ġ, �ӵ�)
       

        //2. SmoothDamp 
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
            
         

        //3.Lerp
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f); 

        //4.Slerp (���� ���� ����)
        transform.position =
            Vector3.Slerp(transform.position, target, 0.001f); */


        /*Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("vertical") * Time.deltaTime);
        transform.Translate(vec);

























        /*
        if (Input.anyKeyDown)          //anyKeyDown: �ƹ� �Է��� ���ʷ� ���� �� true
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("���������� �̵��� ���߾����ϴ�.");
         
        
        if (Input.GetMouseButtonDown(0))
            Debug.Log("�̻��� �߻�!!");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!");
        */



    }
}



