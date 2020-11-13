// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace AddressBook_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook System program using ADO.NET");
            ///Creating Instance object of AddressBookRepository class.
            AddressBookRepository repository = new AddressBookRepository();
            ///UC1 Creating a method for checking for the validity of the connection.
            repository.EnsureDataBaseConnection();
            /// UC2 Getting all the stored records in the address book service table by fetching all the records
            repository.GetAllContact();
            /// UC 3: Adds the new contact into DB table.
            //AddNewContactDetails();
            /// UC 4 Ability to Edit the contactType of the existing contact.
            Console.WriteLine(repository.EditContactUsingName("Neha", "Singh", "Speaker") ? "Update done successfully\n" : "Update failed");
        }
        /// UC 3: Adds the new contact into DB table.
        public static void AddNewContactDetails()
        {
            AddressBookRepository repository = new AddressBookRepository();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Neha";
            model.LastName = "Singh";
            model.Address = "MANSAROVAR";
            model.City = "jaipur";
            model.State = "Rajasthan";
            model.Zip = 788776;
            model.PhoneNumber = 887788779;
            model.EmailId = "neha@gmail.com";
            model.AddressBookName = "neha";
            model.AddressBookType = "Friend";
            Console.WriteLine(repository.AddDataToTable(model) ? "Record inserted successfully\n" : "Failed");
        }
    }
}
