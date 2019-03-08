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


    private void ArraySize(int Input) 
    {
        var nextStates = state.GetnextStates();
        if (Input < nextStates.Length)
        {
            state = nextStates[Input];
        }
    }

    //player controles/input
    private void ManageState()
    {
            var nextStates = state.GetnextStates();

         {
                
                if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))

                {
                    ArraySize(0);
                }

            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    ArraySize(1);
                }
                

           
            else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    ArraySize(2);
                }

            else if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Keypad0))
                {
                    ArraySize(3);
                }   

         }
           

            textComponent.text = state.GetStateStory();

    }
}
