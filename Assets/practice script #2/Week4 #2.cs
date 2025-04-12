using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    void Update()
    {
        // 1.MoveTowards
        /*
        transform.position =
            Vector3.MoveTowards(transform.position, target, 1f);   //등속운동 (현재위치, 목표위치, 속도)
       

        //2. SmoothDamp 
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
            
         

        //3.Lerp
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f); 

        //4.Slerp (구면 선형 보간)
        transform.position =
            Vector3.Slerp(transform.position, target, 0.001f); */


        /*Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("vertical") * Time.deltaTime);
        transform.Translate(vec);

























        /*
        if (Input.anyKeyDown)          //anyKeyDown: 아무 입력을 최초로 받을 때 true
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽으로 이동을 멈추었습니다.");
         
        
        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!");
        */



    }
}



