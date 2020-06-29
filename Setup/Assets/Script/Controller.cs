using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Controller : MonoBehaviour
{
    public XRController left;
    public XRController right;
    public InputHelpers.Button teleportActivation;
    public float activation = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (left)
        {
            left.gameObject.SetActive(CheckIfActivated(left));
        }

        if (right)
        {
            right.gameObject.SetActive(CheckIfActivated(right));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivation, out bool isActivated, activation);
        return isActivated;
    }
}
