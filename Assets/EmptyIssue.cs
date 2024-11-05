using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyIssue : MonoBehaviour
{
    private bool m_hasLogged = false;
    // Start is called before the first frame update
    void Start()
    {
        Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.Full);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_hasLogged)
        {
            return;
        }
        Debug.LogError("This is an error message");
        m_hasLogged = true;
    }
}
