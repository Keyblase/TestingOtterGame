using Game.GameLevel;
using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameLevels
{
    class LevelOne : Scene
    {
        public LevelOne() : base()
        {
            // Add a blue rectangle to the Scene (just to indicate which scene is currently active.)
            AddGraphic(Image.CreateRectangle(100, 100, Color.Blue));
        }

        public override void Update()
        {
            base.Update();

            if (Input.KeyPressed(Key.Space))
            {
                // When the space bar is pressed switch to the SecondScene.
                Game.SwitchScene(new LevelTwo());
            }
        }

    }
}

