
using Raylib_cs;
using System.Numerics;

internal static class Program
{
    public static void Main()
    {
        Raylib.InitWindow(600, 500, "Minesweeper");
        Raylib.SetTargetFPS(60);

        Rectangle tile = new Rectangle(200, 180, 60, 60);
        bool revealed = false;

        while (!Raylib.WindowShouldClose())
        {
            Vector2 mouse = Raylib.GetMousePosition();

            if (Raylib.IsMouseButtonPressed(MouseButton.Left)
                && Raylib.CheckCollisionPointRec(mouse, tile))
            {
                revealed = true;
            }

            Raylib.BeginDrawing();
            Raylib.ClearBackground(new Color(24, 28, 38, 255));

            Raylib.DrawRectangleRounded(
                tile, 0.15f, 6,
                revealed
                    ? new Color(45, 52, 68, 255)
                    : new Color(75, 105, 145, 255));

            if (revealed)
                Raylib.DrawText("1", 223, 194, 28, Color.SkyBlue);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
