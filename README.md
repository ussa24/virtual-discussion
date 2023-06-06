# Virtual Discussion

This Unity project is a job interview simulation that utilizes Speech-to-Text (STT) and Text-to-Speech (TTS) functionalities along with the OpenAI API for question generation. It allows users to practice their interview skills in an immersive environment.

## Requirements
- Unity Editor version: 2021.3.19f1
- OpenAI API key
- Additional Packages:
  - [Oculus Voice SDK](https://developer.oculus.com/documentation/unity)
  - [Ready Player Me](https://readyplayer.me/)
  - [OpenAI-Unity SDK](https://github.com/srcnalt/OpenAI-Unity)
  - [Scene](https://www.cgtrader.com/items/3174279/download-page)

## Getting Started
To use the project, you can either use the Windows Build (build folder in this repository) or follow these steps to open and run the project in Unity:

1. Clone or download this repository.

2. Obtain your OpenAI API credentials (API key + Organization ID).

3. Create a file named `auth.json` with the following fields:
   ```json
   {
     "api_key": "YOUR_API_KEY",
     "organization": "YOUR_ORGANIZATION_ID"
   }
Place this file in the directory: `C:\Users\username\.openai`

4. Launch Unity Editor and load the main scene located at Assets/Scenes.

5. Run the scene.

5. Click on the "Record" button to start recording your speech. The transcribed text will be displayed. Send the recorded text and wait for the response. Once the character starts moving, click on the "Speak" button.

Feel free to explore and enhance your interview skills using this immersive simulation!
