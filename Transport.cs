using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{

    private bool isWatched = false;
    private bool isStatic = false;
    public int timePassed = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Transportation());
        if (isWatched == true) {
            Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y +2,
                                                                  Camera.main.transform.position.z);
            isWatched = false;
        }
    }
    IEnumerator Transportation() {
        yield return new WaitForSeconds(timePassed);
        isWatched = true;
    }
}