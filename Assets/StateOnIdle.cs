using UnityEngine;
using System.Collections;

public class StateOnIdle : ITileState {
    private readonly StatePatternTile tile;

    public StateOnIdle(StatePatternTile statePatternTile) {
        tile = statePatternTile;
    }
    public void OnIdleState() {

    }
    //For one off effects
    public void OnUseState() {

    }

    //For Ongoing effects
    public void OnActiveState() {

    }

    //Updates Tile State
    public void UpdateState() {

    }
}
