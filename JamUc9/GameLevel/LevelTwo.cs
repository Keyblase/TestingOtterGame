using Game.GameLevels;
using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameLevel
{
    class LevelTwo : Scene
    {
        public LevelTwo() : base()
        {
            // Add a red rectangle to the Scene (just to indicate which scene is currently active.)
            AddGraphic(Image.CreateRectangle(100,100, Color.Red));
        }

        public override void Update()
        {
            base.Update();

            if (Input.KeyPressed(Key.Space))
            {
                // When the space bar is pressed switch to the FirstScene.
                Game.SwitchScene(new LevelOne());
            }
        }
    }
}

