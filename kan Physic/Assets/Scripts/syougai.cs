using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    [Header("ˆÚ“®ƒxƒNƒgƒ‹")]
    [SerializeField] private Vector2 velocity = new Vector2(2f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveAmount = (Vector3)(velocity * Time.deltaTime);

        transform.localPosition += transform.localRotation * moveAmount;
    }
}
