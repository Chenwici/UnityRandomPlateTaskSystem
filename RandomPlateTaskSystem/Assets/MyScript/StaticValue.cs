using UnityEngine;

[System.Serializable]
public static class StaticValue
{
    [SerializeField]
    public static int[] MyIntValue = new int[20];          //預設,以備不時之需
    public static float[] MyFloatValue = new float[20];    //預設,以備不時之需
    public static string[] MystrValue = new string[20];    //預設,以備不時之需

    public static int Level = 1; //程序進度
    
}
