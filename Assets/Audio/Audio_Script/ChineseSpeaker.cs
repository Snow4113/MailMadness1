using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class ChineseSpeaker : MonoBehaviour
{
    public ScoreController scoreController; // Reference to the ScoreController
    public string fmodEventPath = "event:/ChineseSpeaker/child labor"; // FMOD Event path for the voice line

    private FMOD.Studio.EventInstance voiceLineEvent;
    private bool voiceLinePlayed = false; // To ensure the voice line is played only once

    void Start()
    {
        // Create an instance of the voice line event
        voiceLineEvent = RuntimeManager.CreateInstance(fmodEventPath);
    }

    void Update()
    {
        // Check if score is 5 and the voice line hasn't been played yet
        if (scoreController.score == 0 && !voiceLinePlayed)
        {
            PlayVoiceLine();
        }
    }

    void PlayVoiceLine()
    {
        // Start the voice line event
        voiceLineEvent.start();
        voiceLinePlayed = true; // Mark the voice line as played
    }

}