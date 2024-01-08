namespace Mazes;

public static class SnakeMazeTask
{
    public static void MoveOut(Robot robot, int width, int height)
    {
        while(!robot.Finished)
        {
            MoveRight(robot, width);
            MoveDown(robot);
            MoveLeft(robot);
            if (!robot.Finished)
            {
                MoveDown(robot);
            }
        }
    }

    private static void MoveDown(Robot robot)
    {
        robot.MoveTo(Direction.Down);
        robot.MoveTo(Direction.Down);
    }

    private static void MoveRight(Robot robot, int width)
    {
        while (robot.X != width - 2)
        {
            robot.MoveTo(Direction.Right);
        }
    }

    private static void MoveLeft(Robot robot)
    {
        while (robot.X != 1)
        {
            robot.MoveTo(Direction.Left);
        }
    }
}