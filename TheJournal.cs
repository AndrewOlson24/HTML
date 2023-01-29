using System.IO;

public class journalEntry
{
    List<journalEntry> journalEntries = new List<JournalEntry>();

    prompt prompt= new promt();

    String lp = "| ";

    string delim = "|";

    Storage files;

    public journal()
    {
        files = new Storage(lp);
    }


    public void AddEntry()
    {
        JournalEntry entry = new JournalEntry();
    }




    public void DisplayAll()
    {
        Console.writeline($"{lp}Number of Journal ENtry to show: {jounralEntries.count}\n");
        foreach(journalEntry entry in journalEntries)
        {
            entry.Display();
        }

        Console.writeline($"{lp}end of journal\n" );

    }


    public void SaveTOFile()
    {
        Console.writeline($"{lp}Ok, Saving to the journal");
        files.clearLines();
        foreach(journalEntry entry in journalEntries)
        {
            files.addline($"{entry._entryDate}{delim}{entry._prompt}{delim}{entry._response}");
            
        }
        string filename = files.writeFile();
        Console.writeline($"{lp}{JournalEntries.count} journal entries written");

    }



    public void ReadFromFIle()
    {
        Console.writeline($"{lp}Reading a Journal");
        string filename = files.readFiles()

        foreach(string line in files.lines)
        {
            JournalEntry entry = new JournalEntry();
            string[] parts = line.split(delim);

            entry._entryDate = part[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            journalEntries.Add(entry);

        }
        console.writeline($"{lp}{journalEntries.count} entries added to the journal");



    }

    public void Menu()
    {
        Console.writeline("welcome to your personal online Journal");
        string selection = "";
        while(slection != "5")
        {
            Console.write("Here is your options: 1-Write, 2- Display, 3-Load, 4-save, 5-quit");
            selection = Console.Readline();
            Console.Writeline();

            if(selection == "1")
            {
                Addentry()
            }
            else if(selection == "2")
            {
                DisplayAll();
            }
            else if(selection == "3");
            {
                Journal();
            }
            else if(selection == "4")
            {
                SaveTOFile();
            }
            else if(selection == "5")
            {
                Console.writeline("Thanks for playing. bye");
            }
            else
            {
                Console.writeline("didnt Catch that, try again?")
            }
        }
    }



}