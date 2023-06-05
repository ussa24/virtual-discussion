using UnityEngine;
using UnityEngine.UI;

public class STTTextReceiver : MonoBehaviour
{
    public Text transcriptionText;

    public void ReceiveTextFromTTS(string text)
    {
        transcriptionText.text = text;
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            gameManager.SetSTTResult(text);
        }
    }

}