using UnityEngine;

public class LookAt : MonoBehaviour
{
    // target that the camera should look at
    static public GameObject target;
    //Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (target){
            transform.LookAt(target.transform);
        }
    }
}
