using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;
using CandyCoded.HapticFeedback;

public class MainPanel : MonoBehaviour
{
    [SerializeField] private Button m_vibrate;
    // Start is called before the first frame update
    void Start()
    {
        m_vibrate.onClick.AddListener(onVibrateClicked);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void onVibrateClicked()
    {
        HapticFeedback.HeavyFeedback();
    }
}
