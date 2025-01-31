namespace Player;

    public class Program 
    {
        public Vector3 Position { get; set; }
        public float speed { get; set; }
        public float JumpForce { get; set; }



        public void Move(float horizontalInput) 
        {
            Position.x += horizontalInput * speed * Time.deltaTime;

        }


        public void Jump()
        {
            if (IsGrounded())
            {
                Position.y += JumpForce;

            }
        }


    
    }
