using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCircleSystemEvent : MonoBehaviour
{
    //public GameObject Circle;
    
    //�x�s�W�@�I
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
                //X(-8,5) Y(-4,4)//�d��

                X = MyRandom.Next(-8, 5);
                Y = MyRandom.Next(-4, 4);
                if (((X + 0.5) > (Temp_X[j] - 0.5)) && ((Y + 0.5) > (Temp_Y[j] - 0.5))) //��3�H��
                {

                }
                else if (((X - 0.5) < (Temp_X[j] + 0.5)) && ((Y - 0.5) < (Temp_Y[j] + 0.5))) //��1�H��
                {

                }
                else if (((X + 0.5) > (Temp_X[j] - 0.5)) && ((Y - 0.5) < (Temp_Y[j] + 0.5))) //��2�H��
                {

                }
                else if (((X - 0.5) < (Temp_X[j] + 0.5)) && ((Y + 0.5) > (Temp_Y[j] - 0.5))) //��4�H��
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
        
        //�Ͳ�10�� XY ��m�����ƪ�����
        for (int i = 0; i < 10; i++)
        {
            //X(-8,5) Y(-4,4)//�d��
            //X = Random.Range(-8.0f, 5.0f);
            //Y = Random.Range(-4.0f, 4.0f);
            //CircleObj[i] = GameObject.Find("Cicle" + i);
            for (int j = 0; j < 10; j++)
            {
                //X(-8,5) Y(-4,4)//�d��
                
                X = MyRandom.Next(-8, 5);
                Y = MyRandom.Next(-4, 4);
                if (((X + 0.5) > (Temp_X[j] - 0.5)) && ((Y + 0.5) > (Temp_Y[j] - 0.5))) //��3�H��
                {
                    
                }
                else if (((X - 0.5) < (Temp_X[j] + 0.5)) && ((Y - 0.5) < (Temp_Y[j] + 0.5))) //��1�H��
                {
                    
                }
                else if (((X + 0.5) > (Temp_X[j] - 0.5)) && ((Y - 0.5) < (Temp_Y[j] + 0.5))) //��2�H��
                {
                    
                }
                else if (((X - 0.5) < (Temp_X[j] + 0.5)) && ((Y + 0.5) > (Temp_Y[j] - 0.5))) //��4�H��
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
