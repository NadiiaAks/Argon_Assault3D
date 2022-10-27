using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    private void Update()
    {
        float horizontalThrow = Input.GetAxis("Horizontal");
        float verticalThrow = Input.GetAxis("Vertical");

        float xOffset = horizontalThrow * Time.deltaTime * controlSpeed;
        float yOffset = verticalThrow * Time.deltaTime * controlSpeed;
        float newXPos = transform.localPosition.x + xOffset;
        float newYPos = transform.localPosition.y + yOffset;

        transform.localPosition = new Vector3 (newXPos, newYPos, transform.localPosition.z);


    }
}
