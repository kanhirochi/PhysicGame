using UnityEngine;

public class SlideTarget : MonoBehaviour
{
    [Header("à⁄ìÆë¨ìx")]
    [SerializeField] private float unitsPerSecond = 2f;

    [Header("à⁄ìÆÇÃïù")]
    [SerializeField] private float moveDistance = 3f;
    
    private bool isMovingForward = true;

    private Vector3 originalLocalPosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalLocalPosition = transform.localPosition;


    }

    // Update is called once per frame
    void Update()
    {
        float distance = unitsPerSecond * Time.deltaTime;

        Vector3 slideDirection = transform.localRotation * Vector3.right;

        Vector3 offset = transform.localPosition - originalLocalPosition;
        float traveledDistance = Vector3.Dot(offset, slideDirection);

        if (isMovingForward)
        {
            if (traveledDistance < moveDistance)
            {
                transform.localPosition += slideDirection * distance;
            }
            else
            {
                isMovingForward = false;
            }
        }
        else
        {
            if (traveledDistance > 0f)
            {
                transform.localPosition -= slideDirection * distance;
            }
            else
            {
                isMovingForward = true;
            }
            
        }
         
           
         



    }
}
