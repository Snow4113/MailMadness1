using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class ChineseSpeaker : MonoBehaviour
{
    public ScoreController scoreController; // Reference to the ScoreControlled  
    public string fmodEventPath1 = "event:/ChineseSpeaker/child labor"; // FMOD Event path for the voice line
    public string fmodEventPath2 = "event:/ChineseSpeaker/good work china";
    public string fmodEventPath3 = "event:/ChineseSpeaker/children work harda";
    public string fmodEventPath4 = "event:/ChineseSpeaker/chinese royal mail";

    private FMOD.Studio.EventInstance voiceLineEvent1;
    private FMOD.Studio.EventInstance voiceLineEvent2;
    private FMOD.Studio.EventInstance voiceLineEvent3;
    private FMOD.Studio.EventInstance voiceLineEvent4;
    private bool voiceLine1Played = false; // To ensure the voice line is played only once
    private bool voiceLine2Played = false;
    private bool voiceLine3Played = false;
    private bool voiceLine4Played = false;

    void Start()
    {
        // Create an instance of the voice line event
        voiceLineEvent1 = RuntimeManager.CreateInstance(fmodEventPath1);
        voiceLineEvent2 = RuntimeManager.CreateInstance(fmodEventPath2);
        voiceLineEvent3 = RuntimeManager.CreateInstance(fmodEventPath3);
        voiceLineEvent4 = RuntimeManager.CreateInstance(fmodEventPath4);
    }

    void Update()
    {
        // Check i and the voice line hasn't been played yet
        if (scoreController.score == 0 && !voiceLine1Played)
        {
            PlayVoiceLine1();

        }
        if(scoreController.score == 20 && !voiceLine2Played)
        {
            PlayVoiceLine2();
        }
        if (scoreController.score == 30 && !voiceLine3Played)
        {
            PlayVoiceLine3();
        }
        if (scoreController.score == 50 && !voiceLine4Played)
        {
            PlayVoiceLine4();
        }
    }

    void PlayVoiceLine1()
    {
        // Start the voice line event
        voiceLineEvent1.start();
        voiceLine1Played = true; // Mark the voice line as played
    }
    void PlayVoiceLine2()
    {
        voiceLineEvent2.start();
        voiceLine2Played = true; 
    }

    void PlayVoiceLine3()
    {
        voiceLineEvent3.start();
        voiceLine3Played = true; 
    }
    void PlayVoiceLine4()
    {
        voiceLineEvent4.start();
        voiceLine4Played = true;
    }
}