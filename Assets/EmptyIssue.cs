using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyIssue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.Full);
        Debug.LogError("This is an error message");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
