using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    private int direction=1;
    public Transform PointA;
    public Transform PointB;
    public float speed;
    public Vector3 location;

    //public int Respawn;

    private void Update()
    {
        if (PointA != null && PointB != null)
        {

            Vector2 target1 = new Vector2(PointA.position.x, transform.position.y);

            Vector2 target2 = new Vector2(PointB.position.x, transform.position.y);

            Vector2 myPosition = new Vector2(transform.position.x, transform.position.y); 



            if (Vector2.Distance(myPosition, target1) < 0.1f)
            {

                direction = 1;

            }
           

            else if (Vector2.Distance(myPosition, target2) < 0.1f)
            {
                direction = -1;

            }
           



            if (direction == 1)
            {
                transform.GetComponent<SpriteRenderer>().flipX = true;
                transform.position += transform.right * Time.deltaTime * speed ;
            }
            else if(direction==-1)
            {
                transform.GetComponent<SpriteRenderer>().flipX = false;
                transform.position += transform.right * Time.deltaTime * -speed ;
            }


            

          

            

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {


        /*
        if (other.CompareTag("Player"))
        {
            Debug.Log("move to scene" + Respawn);
            SceneManager.LoadScene(Respawn);

        }
        */
    }
}
