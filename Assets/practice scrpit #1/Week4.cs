
/*
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Switch;

public class Week4 : MonoBehaviour
{
    int health = 30;
    int mana = 25;
    int level = 5;
    float strength = 15.5f;
    string playername = "나검사";
    int exp = 1500;
    bool isFullLevel = false;


    private void Start()
    {
        Debug.Log("Hello Unity!");

        //변수
        //int level = 5;
        //float strength = 15.5f;
        //string playername = "나검사";
        //bool isFullLevel = false;

        /*
        Debug.Log("용사의 이름은?");
        Debug.Log(playername);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);
        */

         /*
        //그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        /*
      Debug.Log("맵에 존재하는 몬스터");
      Debug.Log(monsters[0]);
      Debug.Log(monsters[1]);
      Debug.Log(monsters[2]);
      */

       // List<string> items = new List<string>();
       // items.Add("생명물약30");
       // items.Add("마나물약30"); 
         
        /*
        items.RemoveAt(0);

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);
        */

        //3. 연산자
        //int exp = 1500;

       /*
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playername);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);

        //int health = 30;
        //int mana = 25;

        //bool isBadCondition = health <= 50 && mana <= 20;  //&&는 and와 같음

        bool isBadCondition = health <= 50 || mana <= 20;  // ||는 or과 같음
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";     // ?앞은 true값 :뒤는 false값
        Debug.Log(condition);

        // 4.키워드
        //int float string bool new List

        // 5.조건문
        if (condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요");
        }
        else
        {
            Debug.Log("플레이어 상태가 좋습니다.");
        }
        if (isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if (isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }

        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형몬스터 출현!");
                break;
            case "악마":
                Debug.Log("중형몬스터 출현!");
                break;
            case "골렘":
                Debug.Log("대형몬스터 출현!");
                break;
            default:                               //default로 선언안한 애 부르기, 떨이처리
                Debug.Log("??? 몬스터가 출현!");
                break;
        }

        //6.반복문
        while (health > 0)                //while괄호 안에는 bool형식의 조건을 넣는다.
        {
            health--;
            if (health > 0)
            {
                Debug.Log("독 데미지를 입었습니다." + health);
            }
            else
            {
                Debug.Log("사망하였습니다.");
            }
            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        for (int count = 0; count < 10; count++)            //for(연산될 변수 ; 조건 ; 연산)
        {
            health++;
            Debug.Log("붕대로 치료중..." + health);
        }

        for (int index = 0; index < monsters.Length; index++)        //배열은 .Lenght , 리스트는 .Count
        {
            Debug.Log("이 지역에 있는 몬스터: " + monsters[index]);
        }
    
        foreach  (string monster in monsters)
        {
            //Debug.Log("이 지역에 있는 몬스터: " + monster);
        }

        //health = Heal(health);
        Heal();

        for (int index = 0; index < monsters.Length; index++) 
        Debug.Log("용사는" + monsters[index] + "에게" + Battle(monsterLevel[index]));


        //8.클래스
        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " +player.level);
        Debug.Log(player.move());
    }
    //7.함수(메소드)
    /* int Heal(int health)             //함수이름 앞에는 함수가 반환하는 타입, 괄호 안에는 함수가 받을 변수를
    {
        health += 10;
        Debug.Log("힐을 받았습니다." + health);
        return health; 
    } */

    
/*
    void Heal()
    {
        health += 10;
        //Debug.Log("힐을 받았습니다." + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다.";

        else
            result = "졌습니다.";

        return result;
    }
    
   



}
*/