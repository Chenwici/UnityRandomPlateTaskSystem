using UnityEngine;

[System.Serializable]
public static class StaticValue
{
    [SerializeField]
    public static int[] MyIntValue = new int[20];          //�w�],�H�Ƥ��ɤ���
    public static float[] MyFloatValue = new float[20];    //�w�],�H�Ƥ��ɤ���
    public static string[] MystrValue = new string[20];    //�w�],�H�Ƥ��ɤ���

    public static int Level = 1; //�{�Ƕi��
    
}
