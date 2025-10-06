using UnityEngine;

public class JumpinBlocks : MonoBehaviour {

    [Header("Stuff")]
    [SerializeField] Transform Block;
    [SerializeField] Vector3 accelerationBegin;
    [SerializeField] Vector3 velBegin;

    Vector3 velocity;
    Vector3 acceleration;
    [SerializeField] float T = 0;
    float yMin;
    enum State {onGround, airBorne};
    State myState = State.onGround;

    void Start()
    {

        yMin = Block.position.y;
    }
    void Update()
    {   if (myState == State.onGround)
        {

            if (Input.GetMouseButtonDown(0))
            {
                myState = State.airBorne;
                T = 0;
                velocity = velBegin;
                acceleration = accelerationBegin;
            }
            
        };

        if (myState == State.airBorne) {
            T += Time.deltaTime;
            if (Block.position.y < yMin)
            {
                Debug.Log("3");
                myState = State.onGround;
                velocity = Vector3.zero;
                acceleration = Vector3.zero;
                Block.position = new Vector3(Block.position.x, yMin, 0);
            }
        };

        velocity += acceleration * Time.deltaTime;
        Block.position += velocity * Time.deltaTime;
    }

}
