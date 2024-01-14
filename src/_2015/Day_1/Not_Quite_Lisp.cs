using System;
using System.IO;

namespace NotQuiteLisp;

public class NotQuiteLisp
{
    public static int GetSantaDestination(String directions) 
    {
        int floor = 0;

        foreach (char direction in directions) 
        {
            try 
            {
                floor += FollowDirection(direction);
            } 
            catch (IOException e) 
            {
                return 0; // TODO figure out how to test for thrown exceptions
            }
        }

        return floor;
    }

    public static int FollowDirection(char direction) 
    {
        switch (direction) 
        {
            case '(':
                return 1;
            case ')':
                return -1;
            default:
                throw new IOException($"Invalid directions: contains character {direction}");
        }
    }

    public static int SantaEntersBasementAt(String directions) 
    {
        int floor = 0;
        int instruction_count = 0;

        foreach (char direction in directions) 
        {
            try 
            {
                floor += FollowDirection(direction);
            } 
            catch (IOException e) 
            {
                return 0; // TODO figure out how to test for thrown exceptions
            }

            instruction_count++;

            if (floor == -1) {
                return instruction_count;
            }
        }

        return 0; // TODO replace with thrown Exception
    }
}