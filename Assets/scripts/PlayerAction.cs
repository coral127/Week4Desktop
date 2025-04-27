using System.Collections;
using System.Collections.Concurrent;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public float Speed;
    public GameManager manager;
    
    float h;
    float v;
    bool isHorizonMove;
    Vector3 dirVec;
    Rigidbody2D rigid;
    Animator anim;
    GameObject scanObject;
    
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //ÀÌµ¿°ª
        h = manager.isAction ? 0 : Input.GetAxisRaw("Horizontal");
        v = manager.isAction ? 0 : Input.GetAxisRaw("Vertical");
        //Debug.Log("Horizontal: " + h + ", Vertical: " + v);
        //Debug.Log("Vertical Input: " + v);

        //Check Button Down & Up
        bool hDown = manager.isAction ? false : Input.GetButtonDown("Horizontal");
        bool vDown = manager.isAction ? false : Input.GetButtonDown("Vertical");
        bool hUp = manager.isAction ? false : Input.GetButtonDown("Horizontal");
        bool vUp = manager.isAction ? false : Input.GetButtonDown("Vertical");

        //Check Horizontal Move
        if (hDown)
            isHorizonMove = true;
        else if (vDown)
            isHorizonMove = false;

        //Animation
        //anim.SetInteger("hAxisRaw", (int)h);
        //anim.SetInteger("vAxisRaw", (int)v);

        //Direction
        if (vDown && v == 1)
            dirVec = Vector3.up;
        else if (vDown && v == -1)
            dirVec = Vector3.down;
        else if (hDown && h == -1)
            dirVec = Vector3.left;
        else if (hDown && h == 1)
            dirVec = Vector3.right;

        //Scan Object
        if (Input.GetButtonDown("Jump") && scanObject != null)
            manager.Action(scanObject);
        
           

       
                
        
    }

    void FixedUpdate()
    {
        //Move
        Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rigid.linearVelocity = moveVec * Speed;
        
        //Ray
        Debug.DrawRay(rigid.position, dirVec * 0.7f,new Color(0,1,0));
        RaycastHit2D rayhit = Physics2D.Raycast(rigid.position, dirVec, 0.7f,LayerMask.GetMask("object"));

        if (rayhit.collider != null)
            scanObject = rayhit.collider.gameObject;
        else 
            scanObject = null;

        

      
    }
}
