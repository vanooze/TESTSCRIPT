using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI PromptText;
    [SerializeField]
    private GameObject containerGameObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void UpdateText(string PromptMessage)
    {
        PromptText.text = PromptMessage;
    }

    public void show()
    {
        containerGameObject.SetActive(true);
    }

    public void hide()
    {
        containerGameObject.SetActive(false);
    }

}