using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
public class TypeEffect : MonoBehaviour
{
    string targetMsg;
    public int CharPerSeconds;
    TextMeshProUGUI msgText;
    int index;
    public GameObject EndCursor;
    float interval;
    AudioSource audioSource;
    public bool isAnim;

    private void Awake()
    {
        msgText = GetComponent<TextMeshProUGUI>();
        audioSource = GetComponent<AudioSource>();
    }
    public void SetMsg(string msg)
    {
        if (isAnim)
        {
            msgText.text = targetMsg;
            CancelInvoke();
            EffectEnd();
        }
        else
        {
            targetMsg = msg;
            EffectStart();
        }
            targetMsg = msg;
        EffectStart();
    }

    void EffectStart()
    {
        msgText.text = "";
        index = 0;
        EndCursor.SetActive(false);

        //Start Animation
        interval = 1.0f / CharPerSeconds;
        Debug.Log(interval);

        isAnim = true;
        
        Invoke("Effecting", interval); 
    }

    void Effecting()
    {
        //End Animation
        if(msgText.text == targetMsg)
        {
            EffectEnd();
            return;
        }
        msgText.text += targetMsg[index];
        
        //sound
        if(targetMsg[index] !=' ' || targetMsg[index] != '.' )
            audioSource.Play();

        index++;

        //Recursive
        Invoke("Effecting", interval);
    }

    void EffectEnd()
    {
        isAnim = false;
        EndCursor.SetActive(true);
        
    }
}
