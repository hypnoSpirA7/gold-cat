using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool test;

    private void Start()
    {
        // 如果 (布林值) {程式內容}
        if(true)
        {
            print("判斷式");
        }
    }

    public bool openDoor;

    private void Update()
    {
        if (openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
    }
}
