using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 100.0F;
    private float direction;
    public Canvas RestartMenu;
    public Transform trans;
    public Text text;
    public int speed=1000;
    public Transform pl;
    public Transform mainPothole;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    		direction = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
            if(pl.position.x<2.3&&pl.position.x>-2.3){
                rb.velocity = Vector2.zero;
                rb.velocity = new Vector2(direction * Time.deltaTime * moveSpeed * speed/1000, 0);
            }
            else{
                //rb.velocity=Vector2.zero;
                //rb.velocity=new Vector2(direction*Time.deltaTime*moveSpeed*speed/1000*-1,0);
                trans.position=new Vector3(-1.48f,-3.57f,88.5f);
            }
            speed=speed+1;
            // Debug.Log(mainPothole.position.y);
            if(mainPothole.position.y<10){
                Debug.Log("<10");
            	text.text="p=15;\ncout<<p--;\na. 12\nb. 10\nc. 21\n";
            }
            else if(mainPothole.position.y<20){
                Debug.Log("<20");
                text.text="int  const * p=5;\nprintf(\"%d\",++(*p));\na. 10\nb. 20\nc. 30\n";
            }
            else if(mainPothole.position.y<30){
                Debug.Log("<30");
                text.text="extern int i;\ni=20;\nprintf(\"%d\",i);\na. 10\nb. 20\nc. 30\n";
            }

            // if(mainPothole.position.y<80){
            //     Application.LoadLevel(1);
            // }

            
            // if(mainPothole.position.y<(100)){
            //     text.text="char *p;\ncout<<sizeof(*p);\na. 1\nb. 2\nc. 3\n";
            // }
            // if(mainPothole.position.y<(120)){
            //     text.text="char *p;\ncout<<sizeof(p);\na. 6\nb. 8\nc. 10\n";
            // }
            // if(mainPothole.position.y<(140)){
            //     text.text="cout<<(-1<<4);\na. -14\nb. -16\nc. -18\n";
            // }
            // if(mainPothole.position.y<(160)){
            //      Application.LoadLevel(2);
            // }

            // if(mainPothole.position.y<(180)){
            //     text.text="int i=10;\ni=!i>14;\ncout<<i;\na. 0\nb. 1\nc. 3\n";
            // }
            // if(mainPothole.position.y<(200)){
            //     text.text="#include <stdio.h>\n#define a 10\nmain()\n{\n#define a 50\ncout<<a\n}\na. 40\nb. 50\nc. 60\n";
            // }
            // if(mainPothole.position.y<(220)){
            //     text.text="main()\n{\nextern int i;\ni=20;\ncout<<sizeof(i);\n}\na. 3\nb. 4\nc. 5\n";
            // }
            // if(mainPothole.position.y<(240)){
            //     Application.LoadLevel(3);

            // }

            // if(mainPothole.position.y<(260)){
            //     text.text="void main()\n{\nint i=5;\ncout<<i++ + ++i;\n}\na. error\nb. 4\nc. 5\n";

            // }
            // if(mainPothole.position.y<(280)){
            //     text.text="main()\n{\nchar not;\nnot=!2;\ncout<<not;\n}\na. 1\nb. 0\nc. 2\n";

            // }
            // if(mainPothole.position.y<(300)){
            //     text.text="main()\n{\nchar not;\nnot=!2;\ncout<<not;\n}\na. 1\nb. 0\nc. 2\n";

            // }
            // if(mainPothole.position.y<(320)){
            //     Application.LoadLevel(4);

            // }

            
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        RestartMenu.gameObject.SetActive(true);
        Destroy(gameObject);
        

        
    }
}
