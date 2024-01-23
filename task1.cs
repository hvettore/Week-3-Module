while(!AtGoal)
{
    CheckAndMove();
}

void CheckAndMove()
{
    if (Peek())
    {
        Move();
    }
    else
    {
        Turn();
        if(!Peek())
        {
            FullTurn();
        }
    }
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

void FullTurn()
{
    // Turns the car 180 deg clockwise.
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