using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;
using CandyCoded.HapticFeedback;

public class MainPanel : MonoBehaviour
{
    [SerializeField] private Button m_heavyVibrate;
    [SerializeField] private Button m_lightVibrate;
    [SerializeField] private Button m_mediumVibrate;
    // Start is called before the first frame update
    void Start()
    {
        if ((m_heavyVibrate != null) && (m_heavyVibrate.onClick != null)) m_heavyVibrate.onClick.AddListener(onHeavyVibrateClicked);
        if ((m_lightVibrate != null) && (m_lightVibrate.onClick != null)) m_lightVibrate.onClick.AddListener(onLightVibrateClicked);
        if ((m_mediumVibrate != null) && (m_mediumVibrate.onClick != null)) m_mediumVibrate.onClick.AddListener(onMediumVibrateClicked);
    }

    void onHeavyVibrateClicked()
    {
        HapticFeedback.HeavyFeedback();
    }
    void onLightVibrateClicked()
    {
        HapticFeedback.LightFeedback();
    }
    void onMediumVibrateClicked()
    {
        HapticFeedback.MediumFeedback();
    }
}
