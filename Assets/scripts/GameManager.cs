using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public TalkManager talkManager;
    public Animator talkPanel;
    public QuestManager questManager;
    public Image portraitImg;
    public Animator portraitAnim;
    public TypeEffect talk;
    public GameObject scanObject;
    public bool isAction;
    public int talkIndex;
    public Sprite prevPortrait;

    void Start()
    {
        
        Debug.Log(questManager.CheckQuest());
    }
    public void Action(GameObject scanObj)
    {
        isAction = false;
        //Get Current Object
        scanObject = scanObj;
        ObjData objData = scanObject.GetComponent<ObjData>();
        Talk(objData.id, objData.isNpc);

        //Visible Talk for Action
        talkPanel.SetBool("isShow", isAction);
    
    }
    void Talk(int id, bool isNpc)
    {
        //set Talk Data
        int questTalkIndex = 0;
        string talkData = "";

        if (talk.isAnim) { 
        talk.SetMsg("");
        return;
    }
        else
        {
            questTalkIndex = questManager.GetQuestTalkIndex(id);
            talkData = talkManager.GetTalk(id + questTalkIndex, talkIndex);
        }

        //End Talk
        if (talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            Debug.Log(questManager.CheckQuest(id));
            return;
        }
        
        //Continue Talk
        if (isNpc)
        {
            talk.SetMsg(talkData.Split(':')[0]);

            //Show Portrait
            portraitImg.sprite = talkManager.GetPortrait(id, int.Parse (talkData.Split(':')[1]));
            portraitImg.color = new Color(1, 1, 1, 1);
            //Animation Portrait
            if(prevPortrait != portraitImg.sprite)
            {
                portraitAnim.SetTrigger("doEffect");
                prevPortrait = portraitImg.sprite;
            }
            
        }
        else
        {
            talk.SetMsg(talkData);

            //Hide Portrait
            portraitImg.color = new Color(1, 1, 1, 0);
        }

        //Next Talk
        isAction = true;
        talkIndex++;
    }
}
