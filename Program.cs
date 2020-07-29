using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Linq;


namespace test2
{
    class Program
    {
        
        
        static void showMenu()
        {
            Console.WriteLine("1. Show Phonebook");
            Console.WriteLine("2. Add Entry");
            Console.WriteLine("3. Edit Entry");
            Console.WriteLine("4. Delete Entry");
            Console.WriteLine("5. Exit");
        }
        public static (string new_Name, Entry new_Entry) creatingEntry()
        {
            Console.WriteLine("Type Name");
            string name = Console.ReadLine();
            Console.WriteLine("Type Last Name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Type phone number type");
            string phonetype = Console.ReadLine();
            Console.WriteLine("Type phone number ");
            string phonenumber = Console.ReadLine();
            Entry newEntry = new Entry(name, lastname, phonetype, phonenumber);
            return (name, newEntry);
        }
        public static void deleteEntry(SortedList<string, Entry> phoneBook)
        {
            Console.WriteLine("Type name of entry your want to delete");
            string name = Console.ReadLine();
            int indexOfKey = phoneBook.IndexOfKey(name);
            Console.WriteLine(indexOfKey);
            if (indexOfKey == -1)
            {
                Console.WriteLine(name + " was not found");
            }
            else
            {
                phoneBook.RemoveAt(indexOfKey);
                Console.WriteLine(name + " has been removed.");

            }

        }



        public static void savePhonebook(SortedList<string, Entry> phoneBook)
        {

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Phonebookfile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, phoneBook);
            stream.Close();
        }

        public static SortedList<string, Entry> loadPhonebook()
        {

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Phonebookfile.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            if (stream.Length == 0)
            {
                stream.Close();
                return new SortedList<string, Entry>(new StringComparer());
            }
            else
            {
                SortedList<string, Entry> obj = (SortedList<string, Entry>)formatter.Deserialize(stream);
                stream.Close();
                return obj;
            }


        }

        static void Main(string[] args)
        {
            SortedList<string, Entry> phoneBook;
            phoneBook = loadPhonebook();
            PhoneBookClass pb1 = new PhoneBookClass();
            string answer;
            do
            {
                showMenu();
                answer = Console.ReadLine();
                Console.WriteLine();

                switch (answer)
                {
                    case "1":
                        pb1.showPhoneBook(phoneBook);
                        break;
                    case "2":
                        (string new_Name, Entry new_Entry) = creatingEntry();
                        pb1.addEntry(new_Name, new_Entry, phoneBook);
                        break;
                    case "3":
                        Console.WriteLine("Which entry would you like to edit ?");
                        //Console.WriteLine(phoneBook.GetKey(0));

                        break;
                    case "4":
                        deleteEntry(phoneBook);
                        break;
                    case "5":

                        savePhonebook(phoneBook);
                        Console.WriteLine("File is saved");
                        break;
                    default:
                        Console.WriteLine("Wrong answer type something of the following");
                        Console.WriteLine();
                        showMenu();
                        answer = Console.ReadLine();
                        Console.WriteLine();
                        break;
                }


            } while (answer.Equals("5") == false);



        }
    }


}
