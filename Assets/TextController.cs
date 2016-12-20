using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TextController : MonoBehaviour
{
    public Text text;
    private enum States { cell, sheets_0, sheets_1, lock_0, lock_1, mirror,
                        cell_mirror, corridor_0, stairs_0, floor, closet_door,
                        stairs_1, corridor_1, in_closet, corridor_3, courtyard };

    private States myState;

    void Start()
    {
        myState = States.cell;
    }

    void Update()
    {
        if (myState == States.cell)
        {
            cell();
        }
        else if (myState == States.sheets_0)
        {
            sheets_0();
        }
        else if (myState == States.sheets_1)
        {
            sheets_1();
        }
        else if (myState == States.lock_0)
        {
            lock_0();
        }
        else if (myState == States.lock_1)
        {
            lock_1();
        }
        else if (myState == States.mirror)
        {
            mirror();
        }
        else if (myState == States.cell_mirror)
        {
            cell_mirror();
        }
        else if (myState == States.corridor_0)
        {
            corridor_0();
        }
        else if (myState == States.stairs_0)
        {
            stairs_0();
        }
        else if (myState == States.floor)
        {
            floor();
        }
        else if (myState == States.closet_door)
        {
            closet_door();
        }
        else if (myState == States.stairs_1)
        {
            stairs_1();
        }
        else if (myState == States.corridor_1)
        {
            corridor_1();
        }
        else if (myState == States.in_closet)
        {
            in_closet();
        }
        else if (myState == States.corridor_3)
        {
            corridor_3();
        }
        else if (myState == States.courtyard)
        {
            courtyard();
        }
    }
    void cell()
    {
        text.text = "You are in a prison cell, and you want to escape. There are " +
                    "some dirty sheets on the bed, a mirror on the wall, and the door " +
                    "is locked from the outside.\n\n" +
                    "Press S to view Sheets, M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
    }

    void mirror()
    {
        text.text = "The dirty old mirror on the wall seems loose.\n\n" +
                    "Press T to Take the mirror, or R to Return to cell";

        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void sheets_0()
    {
        text.text = "You can't believe you sleep in these things. Surely it's " +
                    "time somebody changed them. The pleasures of prison life " +
                    "I guess!\n\n" +
                    "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void sheets_1()
    {
        text.text = "Holding a mirror in your hand doesn't make the sheets look " +
                    "any better.\n\n" +
                    "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void lock_0()
    {
        text.text = "This is one of those button locks. You have no idea what the " +
                    "combination is. You wish you could somehow see where the dirty " +
                    "fingerprints were, maybe that would help.\n\n" +
                    "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void lock_1()
    {
        text.text = "You carefully put the mirror through the bars, and turn it round " +
                    "so you can see the lock. You can just make out fingerprints around " +
                    "the buttons. You press the dirty buttons, and hear a click.\n\n" +
                    "Press O to Open, or R to Return to your cell";

        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.corridor_0;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void cell_mirror()
    {
        text.text = "You are still in your cell, and you STILL want to escape! There are " +
                    "some dirty sheets on the bed, a mark where the mirror was, " +
                    "and that pesky door is still there, and firmly locked!\n\n" +
                    "Press S to view Sheets, or L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }

    void corridor_0()
    {
        text.text = "You are in a big corridor now. There are some stairs close to you and a small closet.\n\n" +
                    "Press F to check the floor, S to go to the stairs or C to check the closet.";

        if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.floor;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_0;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.closet_door;
        }
    }

    void stairs_0()
    {
        text.text = "While you were going to the stairs, you realize that there is no break time and you would be caught immediately." +
                    "So you slowly walk back into the corridor to think of a better option.\n\n" +
                    "Press R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }

    void closet_door()
    {
        text.text = "Dammit, the closet door is locked. Maybe there's something inside it that would help me to escape." +
                    "Maybe I find a way to open it.\n\n" + 
                    "Press R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }

    void floor()
    {
        text.text = "When you search the corridor looking for some other way to escape, you notice something on the floor." +
                    "It's a hair clip! Maybe this can help you with something in the future.\n\n" +
                    "Press H to take the hair clip or press R to return";

        if(Input.GetKeyDown(KeyCode.H))
        {
            myState = States.corridor_1;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }

    void corridor_1()
    {
        text.text = "I am in a big corridor now. There are some stairs close to me and a small closet.\n\n Press S to go to the stairs or C to check the closet.";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_1;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.in_closet;
        }
    }

    void stairs_1()
    {
        text.text = "I do not think a little hair clip can defend you from all the prison guards. Maybe I should go back to the hallway.\n\n" +
                    "Press R to return.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_1;
        }
    }

    void in_closet()
    {
        text.text = "I was able to open the closet with the hair clip! It is a mess inside it. But wait, there's a janitor's outfit here." +
                    "Will I be able to pass unnoticed by the guards with it?\n\n Press D to dress up the outfit or press R to return.";

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.corridor_3;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_1;
        }
    }

    void corridor_3()
    {
        text.text = "I look a little strange with these clothes, but this can be my only way out. I can not stay here forever.\n\n" +
                    "Press S to take the stairs or press U to undress the janitor's outfit";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.courtyard;
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            myState = States.in_closet;
        }
    }

    void courtyard()
    {
        text.text = "Now I'm in the yard and it seems that no guard has noticed me yet. I need to be quick and finally get out of here.\n\n" +
                    "You won the game :)\n\n" +
                    "Press P to play again";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
    }
}