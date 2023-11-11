﻿//
// minecraft_kurwa
// ZlomenyMesic, KryKom
//

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace minecraft_kurwa {
    static class Movement {
        public static float leftRightRot = 0;
        public static float upDownRot = 0;

        public static void Update(Game1 game) {
            HandleMouse(game);
            HandleKeyboard(game);
        }

        private static void HandleMouse(Game1 game) {
            Vector2 difference;
            MouseState mouseState = Mouse.GetState();

            difference.X = (Options.WINDOW_WIDTH / 2) - mouseState.X;
            difference.Y = (Options.WINDOW_HEIGHT / 2) - mouseState.Y;
            leftRightRot = Options.SENSIBILITY * difference.X / 100_000;
            upDownRot = Options.SENSIBILITY * difference.Y / 400;

            Mouse.SetPosition(Options.WINDOW_WIDTH / 2, Options.WINDOW_HEIGHT / 2);

            game.UpdateViewMatrix();
        }

        private static void HandleKeyboard(Game1 game) {
            KeyboardState keyboard = Keyboard.GetState();
            if (keyboard.IsKeyDown(Keys.Escape)) game.Exit();

            float speed = 1 / Options.MOVEMENT_SPEED * 10_000;

            float differenceX = (game.camTarget.X - game.camPosition.X) / speed;
            float differenceZ = (game.camTarget.Z - game.camPosition.Z) / speed;

            if (keyboard.IsKeyDown(Keys.W)) {
                game.camPosition.X += differenceX;
                game.camTarget.X += differenceX;
                game.camPosition.Z += differenceZ;
                game.camTarget.Z += differenceZ;
            }
            if (keyboard.IsKeyDown(Keys.S)) {
                game.camPosition.X -= differenceX;
                game.camTarget.X -= differenceX;
                game.camPosition.Z -= differenceZ;
                game.camTarget.Z -= differenceZ;
            }
            if (keyboard.IsKeyDown(Keys.A)) {
                game.camPosition.Z -= differenceX;
                game.camTarget.Z -= differenceX;
                game.camPosition.X += differenceZ;
                game.camTarget.X += differenceZ;
            }
            if (keyboard.IsKeyDown(Keys.D)) {
                game.camPosition.Z += differenceX;
                game.camTarget.Z += differenceX;
                game.camPosition.X -= differenceZ;
                game.camTarget.X -= differenceZ;
            }
            if (keyboard.IsKeyDown(Keys.Space)) {
                game.camPosition.Y += 200 / speed;
                game.camTarget.Y += 200 / speed;
            }
            if (keyboard.IsKeyDown(Keys.LeftShift)) {
                game.camPosition.Y -= 200 / speed;
                game.camTarget.Y -= 200 / speed;
            }
        }
    }
}
