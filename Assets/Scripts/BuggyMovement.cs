using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
class BuggyMovement : MonoBehaviour
{
  [SerializeField] Rigidbody rigidbody;
  [SerializeField] private float moveSpeed;

  // Start is called before the first frame update
  void Start()
  {
    rigidbody = GetComponent<Rigidbody>();
  }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            var direction = transform.forward;
            rigidbody.AddForce(direction * moveSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            var direction = transform.forward * -1;
            rigidbody.AddForce(direction * moveSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var direction = transform.right * -1;
            rigidbody.AddForce(direction * moveSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            var direction = transform.right;
            rigidbody.AddForce(direction * moveSpeed);
        }

    }

  //========================================
  //Vector3 GetInputTranslationDirection()
  //{
  //  Vector3 direction = new Vector3();
    
  //  if (Input.GetKey(KeyCode.S))
  //  {
  //    direction += Vector3.back;
  //  }
  //  if (Input.GetKey(KeyCode.A))
  //  {
  //    direction += Vector3.left;
  //  }
  //  if (Input.GetKey(KeyCode.D))
  //  {
  //    direction += Vector3.right;
  //  }
  //  //if (Input.GetKey(KeyCode.Q))
  //  //{
  //  //    direction += Vector3.down;
  //  //}
  //  //if (Input.GetKey(KeyCode.E))
  //  //{
  //  //    direction += Vector3.up;
  //  //}
  //  return direction;
  //}
}