using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otter
{
    class Player : Entity
    {
        public float MoveSpeed;

        public const float MoveSpeedSlow = 5;
        public const float MoveSpeedFast = 10;

        public Player(float x, float y) : base(x, y)
        {
            Sprite = Image.CreateRectangle(25, 25, Color.White);
            Sprite.CenterOrigin();
            AddGraphic(Sprite);
            MoveSpeed = MoveSpeedSlow;
        }

        public override void Update()
        {
            base.Update();

            if (Input.KeyDown(Key.W))
            {
                Y -= MoveSpeed;
            }
            if (Input.KeyDown(Key.S))
            {
                Y += MoveSpeed;
            }
            if (Input.KeyDown(Key.A))
            {
                X -= MoveSpeed;
            }
            if (Input.KeyDown(Key.D))
            {
                X += MoveSpeed;
            }

            if (Input.KeyPressed(Key.Space))
            {
                // If the Entity is currently slow,
                if (MoveSpeed == MoveSpeedSlow)
                {
                    // Set the Entity to fast
                    MoveSpeed = MoveSpeedFast;
                    Graphic.Color = Color.Green;
                }
                else
                {
                    MoveSpeed = MoveSpeedSlow;
                    // And make its Color white(normal State).
                    Graphic.Color = Color.White;
                }
            }
        }

        public Image Sprite { get; }
    }

}
