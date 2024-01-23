bool Direction1;
bool Direction2;
bool Direction3;
bool Direction4;

while (!AtGoal)
{
    RouteCheck();
    RouteAct();
}

void RouteCheck()
{
    if (!DeadEndCheck())
    {
        Direction1 = true;
    }
    Turn();

    if (!DeadEndCheck())
    {
        Direction2 = true;
    }
    Turn();

    if (!DeadEndCheck())
    {
        Direction3 = true;
    }
    Turn();

    if (!DeadEndCheck())
    {
        Direction4 = true;
    }
    Turn();
}

void RouteAct()
{
    if (Direction1 == true)
    {
        Move();
        ResetDirection();
        return;
    }
    else if (Direction2 == true)
    {
        Turn();
        Move();
        ResetDirection();
        return;
    }
    else if (Direction3 == true)
    {
        FullTurn();
        Move();
        ResetDirection();
        return;
    }
    else if (Direction4 == true)
    {
        FullTurn();
        Turn();
        Move();
        ResetDirection();
        return;
    }
}

#region Added Basic Functions

void FullTurn()
{
    // Turns the car 180 deg clockwise.
}

void DeadEndCheck()
{
    // Simulates car going to the end of the path. If it hits a dead end, it returns true.
    // If car faces the wall, the code will also return true.
    return true;
}

void BlockPath()
{
    // Registers a cell as inaccessible, car can no longer go through it.
}

void ResetDirection()
{
    Direction1 = false
    Direction2 = false
    Direction3 = false
    Direction4 = false
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