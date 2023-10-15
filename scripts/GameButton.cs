using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButton : MonoBehaviour
{
    public GameObject panel;
    private bool isPanelActive = false;
    void SoundButton()
    {
        isPanelActive = !isPanelActive;
        panel.SetActive(isPanelActive);
    }
}
