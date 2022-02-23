using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float movementSpeed;

	private Rigidbody2D playerRigidBody;

	private Vector2 movementInput;

	void Start()
	{
		playerRigidBody = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		movementInput = GetDirectionInput();
	}

	void FixedUpdate()
	{
		PerformMovement(movementInput, movementSpeed * Time.fixedDeltaTime);
	}

	// Gets directionnal inputs and clamps the direction input vector magnitude to 1
	private Vector2 GetDirectionInput()
	{
		float horizontalInput = Input.GetAxisRaw("Horizontal");
		float verticalInput = Input.GetAxisRaw("Vertical");

		Vector2 dirInput = new Vector2(horizontalInput, verticalInput);
		if (dirInput.magnitude > 1f)
		{
			dirInput.Normalize();
		}
		return dirInput;
	}

	private void PerformMovement(Vector2 movementDirection, float speed)
	{
		playerRigidBody.MovePosition(playerRigidBody.position + movementDirection * speed);
	}
}
