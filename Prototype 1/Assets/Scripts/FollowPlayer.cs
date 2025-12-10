using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, 7, -10);
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player postion by addinf to the player's position
        transform.position = player.transform.position + offset;
    }
}
