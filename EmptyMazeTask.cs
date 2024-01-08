namespace Mazes;

public static class EmptyMazeTask
{
	public static void MoveOut(Robot robot, int width, int height)
	{
			MoveDown(robot, height);
			MoveRight(robot, width);
	}

	private static void MoveDown(Robot robot, int height)
	{
		while(robot.Y != height - 2)
		{
			robot.MoveTo(Direction.Down);
		}
	}

    private static void MoveRight(Robot robot, int width)
    {
        while (robot.X != width - 2)
        {
            robot.MoveTo(Direction.Right);
        }
    }
}