using System.Collections;
using UnityEngine;
using UnityEngine.Events;


public class Player : MonoBehaviour
{

    public UnityEvent death;

    [SerializeField] PlayerCFG playerCFG;
    
    public int levelId;
    
    public void SetConfig(PlayerCFG config)
    {
        playerCFG = config;
    }

    int jumpStack = 0;

    Rigidbody2D rb;

    private bool _isMobileDevice = false;
    void Start()
    {
        if(Application.platform == RuntimePlatform.Android)
            _isMobileDevice = true;


        playerCFG = Storage.instance.PlayerConfigs.GetConfigById(levelId);
        rb = GetComponent<Rigidbody2D>();
        Cursor.visible = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            gameObject.layer = 7;
        if (GetInput())
            Jump();
    }

    bool GetInput()
    {
        if (_isMobileDevice && Input.GetTouch(0).phase == TouchPhase.Began)
            return true;
        if(!_isMobileDevice && Input.GetKeyDown(KeyCode.Space))
            return true;

        return false;
    }

    private void FixedUpdate()
    {
        float newX = rb.position.x + playerCFG.Vel * Time.fixedDeltaTime;
        rb.position = new Vector2(newX, rb.position.y);
    }


    IEnumerator AddStack()
    {
        jumpStack++;
        Debug.Log(jumpStack);

        yield return new WaitForSeconds(playerCFG.stackRessetTime);

        jumpStack = 0;
    }


    void Jump()
    {
       // if (rb.velocity.y != 0)
        //{
            
            
            

        //}
        Debug.Log(rb.velocity -= new Vector2(0,playerCFG.jumpVelReduction));
        rb.AddForce(Vector2.up * JumpForceToApply(), ForceMode2D.Force);
        Debug.Log(rb.velocity);

        if (JumpForceToApply() != 0)
        {
            StopAllCoroutines();
            StartCoroutine(AddStack());
        }

    }

    float JumpForceToApply()
    {
        float jumpForce = (playerCFG.JumpForce + Random.Range(-playerCFG.randomFactor / 2, playerCFG.randomFactor)) - (jumpStack * playerCFG.jumpStackSanction);
        jumpForce = jumpForce > 0 ? jumpForce : 0;
        return jumpForce;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {       
        

        if(PlayerPrefs.GetInt("AutoReplay") == 0)
        {
            WindowManager.instance.OpenFailMenu();
        }
        else
        {
            SceneController.Instance.ReOpenScene(1.5f);
        }

        Destroy(gameObject);
        death.Invoke();

    }



    

}
