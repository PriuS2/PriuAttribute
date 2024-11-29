using PriuAttribute;
using UnityEngine;

public class Sample_ButtonAttribute : MonoBehaviour
{
    [Button]
    public void Sample_Button()
    {
        Debug.Log("() => Sample_Button()");
    }

    [Button("CustomButtonName")]
    public void Sample_ButtonName()
    {
        Debug.Log("() => Sample_ButtonName()");
    }

    [Button("ButtonParm_String", "HelloWorld")]
    public void Sample_Button_stringParm(string parmA)
    {
        Debug.Log($"() => {parmA}");
    }

    [Button("ButtonParm_Int", (int)3, (int)5)]
    public void Button_Add(int a, int b)
    {
        Debug.Log($"() => {a} + {b} = {a+b}");
    }
}
