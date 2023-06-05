using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections.Generic;

namespace OpenAI
{
    public class ChatGPT : MonoBehaviour
    {
        [SerializeField] private Text inputText;
        [SerializeField] private Button button;
        [SerializeField] private ScrollRect scroll;

        [SerializeField] private RectTransform sent;
        [SerializeField] private RectTransform received;

        [SerializeField] private InputField generatedInputField;
        [SerializeField] private Text generatedText;
        
        private float height;

        public UnityEvent OnReplyReceived;
        private OpenAIApi openai = new OpenAIApi();

        private List<ChatMessage> messages = new List<ChatMessage>();
        private string prompt = "I want you to act as an expert in data science & machine learning. You are asked to take my technical interview for data analytics leader position and share your feedback. In my new job, I will like to lead data analytics initiatives across the procurement organization while reporting to head of procurement. When I ask you to start taking interview, then start asking questions. I will say the phrase “start the interview” for you to start. Ask one question at a time. Then, ask another question after I provided the answer. Continue this process until I ask you to stop. And, you will stop the interview when I tell you to stop using the phrase “stop the interview”. After that, you would provide me feedback when I ask you using the phrase, “share your feedback”. Please say start by greeting and welcoming by introducing yourself as 'Badar Hirchoua'. Don't mention that you are an AI.";

        private void Start()
        {
            button.onClick.AddListener(SendReply);
        }

        private async void SendReply()
        {
            var newMessage = new ChatMessage()
            {
                Role = "user",
                Content = inputText.text
            };

            Debug.Log(newMessage.Content);

            if (messages.Count == 0) newMessage.Content = prompt + "\n" + inputText.text;

            messages.Add(newMessage);

            inputText.text = "";
            inputText.enabled = false;

            // Complete the instruction
            var completionResponse = await openai.CreateChatCompletion(new CreateChatCompletionRequest()
            {
                Model = "gpt-3.5-turbo-0301",
                Messages = messages
            });
            
            //

        //    OnReplyReceived.Invoke();
            
            if (completionResponse.Choices != null && completionResponse.Choices.Count > 0)
            {
                var message = completionResponse.Choices[0].Message;
                message.Content = message.Content.Trim();

                messages.Add(message);
                generatedInputField.text = message.Content; // Stocke le texte généré dans le champ de texte modifiable
                generatedText.text = message.Content; // Stocke le texte généré dans le texte statique
                Debug.Log(message.Content);
            }
            else
            {
                Debug.LogWarning("No text was generated from this prompt.");
            }

            inputText.enabled = true;
        }
    }
}
