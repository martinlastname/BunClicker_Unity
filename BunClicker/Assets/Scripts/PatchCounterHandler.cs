using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatchCounterHandler : MonoBehaviour
{

    public UnityEngine.UI.Text patchCount;

    // Use this for initialization
    void Start()
    {
        patchCount.text = string.Format(Text.STR_NUM_PATCH, Vars.Patches.getNumPatches());
    }

    // Update is called once per frame
    void Update()
    {
        patchCount.text = string.Format(Text.STR_NUM_PATCH, Vars.Patches.getNumPatches());
    }
}
