using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textClass : MonoBehaviour
{
    // Start is called before the first frame update
    public Text pelindromLabel;

    // Update is called once per frame
    void Update()
    {
        Vector3 pelindromPosition = Camera.main.WorldToScreenPoint(this.transform.position);
        pelindromLabel.transform.position = pelindromPosition;
    }
}
