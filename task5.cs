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
    if (Peek())
    {
        Direction1 = true
    }
    Turn();
    if (Peek())
    {
        Direction2 = true
    }
    Turn();
    if (Peek())
    {
        Direction3 = true
    }
    Turn();
    if (Peek())
    {
        Direction4 = true
    }
    Turn();
}

void RouteAct()
{
    if (Direction1 == true)
    {
        Move();
    }
    else if (Direction2 == true)
    {
        Turn();
        Move();
    }
    else if (Direction3 == true)
    {
        FullTurn();
        Move();
    }
    else if (Direction4 == true)
    {
        FullTurn();
        Turn();
        Move();
    }

    ResetDirection();
}

#region Added Basic Functions

void FullTurn()
{
    // Turns the car 180 deg clockwise.
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
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion