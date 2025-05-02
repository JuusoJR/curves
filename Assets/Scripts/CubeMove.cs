using UnityEngine;
using UnityEngine.Rendering;

public class CubeMove : MonoBehaviour
{
    [SerializeField] public Curve curve;
    [SerializeField] public float test;
    public float speed = 1f;

    public void Start()
    {
        Debug.Log(Mathf.Lerp(0, 500, 0.7f));
    }

    public void Update()
    {
         if (test > 1f)
        {
            speed*= -1f;
        }
        
        else if (test < 0f)
        {
            speed*= -1f;
        }
        test += Time.deltaTime * speed;
        transform.position = curve.GetPoint(test);
       


    }



}
