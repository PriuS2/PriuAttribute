using PriuAttribute;
using PriuConsole;
using UnityEngine;

public class Sample_PriuConsole : MonoBehaviour
{
    public string command = "TestConsoleCommand";

    [Button]
    public void ExecuteCommand()
    {
        PriuConsoleManager.ExecuteCommand(command);
    }


    [ConsoleCommand("TestConsoleCommand")]
    public void TestConsoleCommand()
    {
        Debug.Log("TestConsoleCommand()");
    }

}
