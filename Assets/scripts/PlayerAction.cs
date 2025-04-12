using System.Collections;
using System.Collections.Concurrent;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public float Speed;

    float h;
    float v;
    bool isHorizonMove;

    Rigidbody2D rigid;
    Animator anim;
 
    
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //ÀÌµ¿°ª
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        //Debug.Log("Horizontal: " + h + ", Vertical: " + v);
        Debug.Log("Vertical Input: " + v);

        //Check Button Down & Up
        bool hDown = Input.GetButtonDown("Horizontal");
        bool vDown = Input.GetButtonDown("Vertical");
        bool hUp = Input.GetButtonDown("Horizontal");
        bool vUp = Input.GetButtonDown("Vertical");

        //Check Horizontal Move
        if (hDown)
            isHorizonMove = true;
        else if (vDown)
            isHorizonMove = false;

        //Animation
        anim.SetInteger("hAxisRaw", (int)h);
        anim.SetInteger("vAxisRaw", (int)v);

    }

    private void FixedUpdate()
    {
        //Move
        Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rigid.linearVelocity = moveVec * Speed;
        Debug.Log("Velocity: " + rigid.linearVelocity);
    }
}
