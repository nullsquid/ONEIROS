using UnityEngine;
using System.Collections;

public class StateOnActive : ITileState {
    private readonly StatePatternTile tile;

    public StateOnActive(StatePatternTile statePatternTile) {
        tile = statePatternTile;
    }
    public void OnUseState() {
        
    }

	public void OnActiveState() {

    }

    public void OnIdleState() {


    }

    public void UpdateState() {

    }
}
