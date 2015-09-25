using UnityEngine;
using System.Collections;

public class StateOnUse : ITileState {
    private readonly StatePatternTile tile;
    
    public StateOnUse (StatePatternTile statePatterTIle) {
        tile = statePatterTIle;
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
