using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCircleSystemEvent : MonoBehaviour
{
    //public GameObject Circle;
    
    //儲存上一點
    float[] Temp_X = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
    float[] Temp_Y = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
    //float[] Temp_Z = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    float X = 0;
    float Y = 0;
    float Z = 0;
    System.Random MyRandom = new System.Random();

    public GameObject[] CircleObj = new GameObject[10];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            CircleObj[i] = GameObject.Find("Circle" + i);

            for (int j = 0; j < 10; j++)
            {
                //X(-8,5) Y(-4,4)//範圍

                X = MyRandom.Next(-8, 5);
                Y = MyRandom.Next(-4, 4);
                if (((X + 0.5) > (Temp_X[j] - 0.5)) && ((Y + 0.5) > (Temp_Y[j] - 0.5))) //第3象限
                {

                }
                else if (((X - 0.5) < (Temp_X[j] + 0.5)) && ((Y - 0.5) < (Temp_Y[j] + 0.5))) //第1象限
                {

                }
                else if (((X + 0.5) > (Temp_X[j] - 0.5)) && ((Y - 0.5) < (Temp_Y[j] + 0.5))) //第2象限
                {

                }
                else if (((X - 0.5) < (Temp_X[j] + 0.5)) && ((Y + 0.5) > (Temp_Y[j] - 0.5))) //第4象限
                {

                }
                else
                {
                    j = 0;
                }
            }

            Temp_X[i] = X;
            Temp_Y[i] = Y;
            Vector3 pos = new Vector3(Temp_X[i], Temp_Y[i], Z);
            CircleObj[i].transform.position = pos;

        }
        //StartCoroutine(MySetTimeOut());
    }
    IEnumerator MySetTimeOut()
    {
        
        //生產10顆 XY 位置不重複的物件
        for (int i = 0; i < 10; i++)
        {
            //X(-8,5) Y(-4,4)//範圍
            //X = Random.Range(-8.0f, 5.0f);
            //Y = Random.Range(-4.0f, 4.0f);
            //CircleObj[i] = GameObject.Find("Cicle" + i);
            for (int j = 0; j < 10; j++)
            {
                //X(-8,5) Y(-4,4)//範圍
                
                X = MyRandom.Next(-8, 5);
                Y = MyRandom.Next(-4, 4);
                if (((X + 0.5) > (Temp_X[j] - 0.5)) && ((Y + 0.5) > (Temp_Y[j] - 0.5))) //第3象限
                {
                    
                }
                else if (((X - 0.5) < (Temp_X[j] + 0.5)) && ((Y - 0.5) < (Temp_Y[j] + 0.5))) //第1象限
                {
                    
                }
                else if (((X + 0.5) > (Temp_X[j] - 0.5)) && ((Y - 0.5) < (Temp_Y[j] + 0.5))) //第2象限
                {
                    
                }
                else if (((X - 0.5) < (Temp_X[j] + 0.5)) && ((Y + 0.5) > (Temp_Y[j] - 0.5))) //第4象限
                {
                    
                }
                else
                {
                    j = 0;
                }
            }
            
            Temp_X[i] = X;
            Temp_Y[i] = Y;
            Vector3 pos = new Vector3(Temp_X[i], Temp_Y[i], Z);
            CircleObj[i].transform.position = pos;
            yield return null;
        }
    }
}
