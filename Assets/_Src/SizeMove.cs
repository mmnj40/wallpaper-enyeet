
using UnityEngine;

public class SizeMove : MonoBehaviour
{


    void Update()
    {
        float rSize = Random.Range(0f, 5f);
        transform.localScale = new Vector3(rSize, rSize, rSize);
    }
}
