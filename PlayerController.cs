using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnPoint;

    public float coolDownTime = 0.5f;
    private bool canShoot=true;
    private SpriteRenderer my2DspriteRendere;

    private Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        my2DspriteRendere = GetComponent<SpriteRenderer>();
        timer = new Timer(coolDownTime , true);

    }

    // Update is called once per frame
    void Update()
    {
       timer.RunTimer();
    }

    void OnMouseUp() {
        if(timer.IsTimeOut()) {
           GameObject temp =  Instantiate(bullet , spawnPoint.transform.position , Quaternion.identity);
            temp.GetComponent<Bullet>().SetBulletProperties(my2DspriteRendere.color);
            timer.RestTimer();
        }
    }

    

  
}
