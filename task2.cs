while(!AtGoal)
{
    CheckAndMove():
}

#region Basic functions

void CheckAndMove()
{
    if (Peek())
    {
        Move();
    }
    else
    {
        Turn();
    }
}

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