using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class EnemyController : MonoBehaviour
{

    private SpriteRenderer my2DSpriteRenderer;

    private GameObject opponent;

    private GameObject player;

    Color[] colors = new Color[5];
    // Start is called before the first frame update
    void Start()
    {
        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.black;
        colors[3] = Color.black;
        colors[4] = Color.cyan;

        opponent = GameObject.FindGameObjectWithTag("Opponent");
        player = GameObject.FindGameObjectWithTag("Player");
        my2DSpriteRenderer = GetComponent<SpriteRenderer>();
        SetColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetColor(){
        my2DSpriteRenderer.color = colors[Random.Range(0 , colors.Length)];
    }


    void OnTriggerEnter2D(Collider2D collider){
        if(collider.tag.Equals("Bullet")){

            /*set the Player color to this gameoject color*/
            player.GetComponent<SpriteRenderer>().color = my2DSpriteRenderer.color;

            /*set the opponet color back to white*/
            opponent.GetComponent<OpponetController>().ResetColor();

            GameObject.Destroy(collider.gameObject);
            
            PlayAnimation();
        }
    }

    void PlayAnimation(){}

    
}
