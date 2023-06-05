using UnityEngine;

public class GameManager : MonoBehaviour
{
    public STTTextReceiver sttTextReceiver;
    private string sttResult;


    public void SendTextToSTT(string text)
    {
        sttTextReceiver.ReceiveTextFromTTS(text);
    }

    public string GetSTTResult()
    {
        return sttResult;
    }

    public void SetSTTResult(string result)
    {
        sttResult = result;
    }


}
