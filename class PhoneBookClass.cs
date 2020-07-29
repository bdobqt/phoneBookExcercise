using System;
using System.Collections.Generic;

class PhoneBookClass
{
      

    public PhoneBookClass()
    {
       
       
    }
    
   
    public void addEntry(string key, Entry value, SortedList<string, Entry> phonebook )
    {
        phonebook[key] = value;
        
    }

    public void editEntry(SortedList<string, Entry> phonebook)
    {
        Console.WriteLine();
        Console.WriteLine("Type the name of the entry you would like to change");
        //search change
        


    }

    
    public void showPhoneBook(SortedList<string, Entry> phonebook)
    {
        foreach( KeyValuePair<string, Entry> kvp in phonebook )
        {
            Console.WriteLine("Key = {0}, Value = {1}",
                kvp.Key, kvp.Value.LastName);
        }
        
      

    }
}