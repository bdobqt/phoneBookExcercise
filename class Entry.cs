using System;

[Serializable] 
class Entry
    {

       public Entry(string first, string last, string pNT, string pN)
       {
           firstName = first;
           lastName = last;
           numberType = pNT;
           phoneNumber = pN;

       }
       private string firstName;
       private string lastName;
       private string numberType;
       private string phoneNumber;

       public void showEntry()
       {
           Console.WriteLine("First Name : {0}, Last Name : {1}, PhoneNumber Type : {2}, PhoneNumber : {3}",firstName, lastName, numberType, phoneNumber);

       }
       public string FirstName
       {
           get{ return firstName; }
           set{ firstName = value; }
       }
       public string LastName
       {
           get{ return lastName; }
           set{ lastName = value; }
       }

       public string PhoneNumber
       {
           get{ return phoneNumber; }
           set{ phoneNumber = value; } 
       }
       
       public string NumberType
       {
           get{ return numberType; }
           set{ numberType = value; } 

       }

    }