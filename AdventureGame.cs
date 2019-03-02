using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    


    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }
    
    //player controles/input
    private void ManageState()
    {
        var nextStates = state.GetnextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))

        {
            state = nextStates[0];
        }

        else if (Input.GetKeyDown(KeyCode.Keypad1))

        {
            state = nextStates[0];
        }


        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))

        {
            state = nextStates[1];
        }


        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            state = nextStates[2];
        }


        else if (Input.GetKeyDown(KeyCode.Space))
        {
            state = nextStates[3];
        }

        else if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            state = nextStates[3];
        }


        textComponent.text = state.GetStateStory();

    }
}
