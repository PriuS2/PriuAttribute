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


    [ConsoleCommand("TestConsoleCommand_Static")]
    public static void TestConsoleCommand_Static()
    {
        Debug.Log("TestConsoleCommand_Static()");
    }
    
    [ConsoleCommand("TestConsoleCommand")]
    public void TestConsoleCommand()
    {
        Debug.Log("TestConsoleCommand()");
    }

    [Button]
    public void DebugAllConsoleCommand()
    {
        PriuConsoleManager.DebugCommands();
    }
}
