while (!AtGoal)
{
    MazeRun();
}

void MazeRun()
{
    if (CheckRight())
    {
        Turn();
        Move();
    }
    else if (Peek())
    {
        Move();
    }
    else if (CheckLeft())
    {
        TurnLeft();
        Move();
    }
    else
    {
        FullTurn();
        Move();
    }
}

void CheckLeft()
{
    TurnLeft()
    if (Peek())
    {
        Turn();
        return true;
    }
}

void CheckRight()
{
    Turn();
    if (Peek())
    {
        TurnLeft();
        return true;
    }
}

void TurnLeft()
{
    Turn();
    Turn();
    Turn();
}

#region Added Basic Functions

void FullTurn()
{
    Turn();
    Turn();
}

#region Basic functions

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true;
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true;
}

#endregion