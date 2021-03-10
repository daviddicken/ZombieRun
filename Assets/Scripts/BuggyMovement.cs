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
    var forward = transform.forward;
    rigidbody.AddForce(transform.forward * moveSpeed);
  }
}