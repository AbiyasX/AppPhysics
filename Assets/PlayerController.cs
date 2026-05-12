using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float rotation = 10f;
    public Transform muzzle;
    public GameObject bullet;
    public float BulletForce = 100f;
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            this.transform.Rotate(0, -rotation * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, rotation * Time.deltaTime, 0);
        }


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           GameObject objBullet = Instantiate(bullet, muzzle.transform.position, muzzle.transform.localRotation);
            objBullet.GetComponent<Rigidbody>().AddForce(muzzle.transform.forward * BulletForce, ForceMode.Impulse);
            objBullet.GetComponent<Rigidbody>().AddTorque(muzzle.transform.right * 50f, ForceMode.Impulse);
        }
    }
}
