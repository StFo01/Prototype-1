using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera cameraA;
    public Camera cameraB;

    private bool usingA = true;

    void Start()
    {
        cameraA.enabled = true;
        cameraB.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            usingA = !usingA;
            cameraA.enabled = usingA;
            cameraB.enabled = !usingA;
        }
    }
}
