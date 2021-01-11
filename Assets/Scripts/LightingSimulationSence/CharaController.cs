using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour {

    private CharacterController characterController;
    private AudioSource audioSource;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float x_sensi = 7.0f;
    public float y_sensi = 7.0f;
    public new GameObject camera;

    public AudioClip[] clips;
    double start_time;
    double call_time;

    private Vector3 moveDirection;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
        start_time = Time.time;
    }

    void Update()
    {
        movecon();
        cameracon();
    }

    void FixedUpdate()
    {
        footstep();
    }

    void movecon()
    {
        if (characterController.isGrounded)
        {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")); //通常移動
            moveDirection *= speed;

            if (Input.GetKey(KeyCode.Space)) //ジャンプ
            {
                moveDirection.y = jumpSpeed;
            }

        }
        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }

    void cameracon() //カメラの方向の変更
    {
        float x_Rotation = Input.GetAxis("Mouse X");
        float y_Rotation = Input.GetAxis("Mouse Y");
        x_Rotation = x_Rotation * x_sensi;
        y_Rotation = y_Rotation * y_sensi;
        this.transform.Rotate(0, x_Rotation, 0);
        camera.transform.Rotate(-y_Rotation, 0, 0);
    }

    void footstep() //足音
    {
        call_time = Time.time;

        if ((Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
            && Input.GetKey("space") == false 
            && call_time - start_time > 0.7d)
        {
            audioSource.PlayOneShot(clips[Random.Range(0, clips.Length)]);
            start_time = Time.time;
        }

        else if (Input.GetKey("space") && call_time - start_time > 0.8d)
        {
            audioSource.PlayOneShot(clips[Random.Range(0, clips.Length)]);
            start_time = Time.time;
        }
    }

}