using System;

namespace Mazes;

public static class DiagonalMazeTask
{
    public static void MoveOut(Robot robot, int width, int height)
    {
        if (width > height)
        {
            MovingInHorizontalMaze(robot, Math.Round((decimal)width / height));
        }
        else
        {
            MovingInVerticalMaze(robot, Math.Round((decimal)height / width));
        }
    }

    private static void MovingInHorizontalMaze(Robot robot, decimal steps)
    {
        while (!robot.Finished)
        {
            MoveRight(robot, steps);
            if (!robot.Finished)
            {
                robot.MoveTo(Direction.Down);
            }
        }
    }

    private static void MovingInVerticalMaze(Robot robot, decimal steps)
    {
        while(!robot.Finished)
        {
            MoveDown(robot, steps);
            if (!robot.Finished)
            {
                robot.MoveTo(Direction.Right);
            }
        }
    }


    private static void MoveDown(Robot robot, decimal steps)
    {
        while (steps > 0)
        {
            robot.MoveTo(Direction.Down);
            steps--;
        }
    }

    private static void MoveRight(Robot robot, decimal steps)
    {
        while (steps > 0)
        {
            robot.MoveTo(Direction.Right);
            steps--;
        }
    }
}