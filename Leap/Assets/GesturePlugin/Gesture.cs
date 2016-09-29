using UnityEngine;
using System.Collections;
using Leap;

public class Gesture {

    private bool[] fingerStates;


    public Gesture(bool[] fingerStates)
    {
        this.fingerStates = fingerStates;
    }

    public bool isSatisfied(Hand hand)
    {
        for(int i=0; i<5;i++)
        {
            if (hand.Fingers[i].IsExtended != fingerStates[i])
                return false; 
        }
        return true;
    }


}
