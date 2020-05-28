using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenerateGraphs : MonoBehaviour {
    public List<Substance.Game.SubstanceGraph> graphs = new List<Substance.Game.SubstanceGraph>();
    void Start() {
        foreach (Substance.Game.SubstanceGraph g in graphs) {
            g.SetInputVector2Int("$outputsize", 10, 10);
            g.QueueForRender();
        }
        Substance.Game.Substance.RenderSubstancesAsync();
    }
}
