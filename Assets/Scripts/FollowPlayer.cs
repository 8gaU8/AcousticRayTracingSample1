using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    public float mouseSensitivity = 5.0f;
    private Vector3 offset = new(0, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.SetPositionAndRotation(player.transform.position, player.transform.rotation);
    }
}
