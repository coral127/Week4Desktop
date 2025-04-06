using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    private void Awake()
    {
        float    floatValue  = 69.6875f;
        double doublevalue = (double)float;
        
        Debug.Log
        
        /* 06. 부호 있는 정수와 부호 없는 정수 사이의 형 변환
        sbyte sbyteValue = 31;
        byte byteValue = (byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        //Type02. 부호 있는 정수가 음수일 때
        sbyteValue = -31;
        byteValue = (byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("bytealue : " + byteValue);

        // Type04. 부호 없는 정수가 부호 있는 정수 최대값보다 클 때
        byteValue    = 200;
        sbyteValue = (sbyte)byteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);
        
        
        /* 05. 크기가 서로 다른 정수(int, sbyte)사이의 형 변환
        sbyte sbyteValue = 10;
        int intValue = (int)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);

        // sbyte의 최대 범위인 127보다 큰 130을 전달하기 때문에 오버플로우 발생
        intValue   = 130;                    //int   -2147483648 ~ 2147483647
        sbyteValue = (sbyte)intValue;        //sbyte -128 ~ 127

        Debug.Log("sbyteValue :" + sbyteValue);
        Debug.Log("intValue :" + intValue);
                
         /* 04. 오브젝트 변수
        object valueInt = 31;
        object valueFloat = 3.141592f;
        object valueString = "객체지향 프로그램";
        object valueBool = false;

        Debug.Log("정수 : " + valueInt);
        Debug.Log("실수 : " + valueFloat);
        Debug.Log("문자열 : " + valueString);
        Debug.Log("논리 : " + valueBool);    
               
            
      
        /* 03. 문자열, 논리
        string stringValue = "Hello World";
        bool boolValue = true;

        Debug.Log("string Data :" + stringValue);
        Debug.Log("bool Data :" + boolValue);



        /* 02 실수
        float floatValue01 = 3.14159265358979f;                    // 7자리 표현
        float floatValue02 = 31.14159265358979f;                   // 7 자리 표현
        double doubleValue = 3.141592653589793238462643383279;     // 15자리 표현
        decimal decimalValue = 3.141592653589793238462643383279m;  // 29자리 표현

        Debug.Log("float Data : " + floatValue01);
        Debug.Log("float Data : " + floatValue02);
        Debug.Log("double Data : " + doubleValue);
        Debug.Log("decimal Data : " + decimalValue);

        
        
        /* 01. 정수
        sbyte byteValue = -128;              //-128~127
        byte ubyteValue = 255;               //0~255
        short shortValue = -32768;            //-32768 ~ 32767
        ushort ushortValue = 65535;             // 0 ~ 65535
        int intValue = -2147483648;       // -1247483648 ~ 2147483647
        uint uintValue = 4294967295;             // 0 ~ 4294967295
        long longVaule = -922337203685477508;    //-9223372036685477508 ~ 922337203685477507
        char charValue = 'k';                    // 0 ~ 18446744073709551615

        Debug.Log("byte Data : " + byteValue);
        Debug.Log("ubyte Data : " + ubyteValue);
        Debug.Log("short Data :" + shortValue);
        Debug.Log("ushort Data :" + ushortValue);
        Debug.Log("int Data :" + intValue);
        Debug.Log("uint Data : " + uintValue);
        Debug.Log("long Data : " + longVaule);
        Debug.Log("chat Data : " + charValue);
    */
        }
}