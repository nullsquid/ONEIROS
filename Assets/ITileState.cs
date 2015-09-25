using UnityEngine;
using System.Collections;

public interface ITileState {
    //when waiting to be triggered
    void OnIdleState();
    //For one off effects
    void OnUseState();

    //For Ongoing effects
    void OnActiveState();

    //Updates Tile State
    void UpdateState();

    
    //void TileOnState();

    //void TileOffState();

    
}

    //tie division to some kind of game scenario
    //samplecode that works