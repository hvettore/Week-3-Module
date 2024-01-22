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
        if(!Peek())
        {
            FullTurn();
            if(!Peek())
            {
                DeadEndTurn();
                Move();
                DeadEndTurn()
                if(!Peek())
                {
                    FullTurn();
                }
            }
        }
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

void FullTurn()
{
    // Turns the car 180 deg clockwise.
}

void Revese()
{
     // Moves the car 1 cell in the opposite direction it is heading.
}

void DeadEndTurn()
{
    // Turns the car 90 deg anti-clockwise.
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