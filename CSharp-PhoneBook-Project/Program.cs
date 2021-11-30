using System;
using System.Collections.Generic;

namespace CSharp_PhoneBook_Project
{
    class Program
    {
        static void Main(string[] args)
        {    
            //Let's create 5 contacts by deafult and add them to the directory after the program starts.
            Contact DeafultContact1 = new Contact("Abdi", "Ali", "5548968595");
            Contact DeafultContact2 = new Contact("Maxames", "Osman", "5214789656");
            Contact DeafultContact3 = new Contact("Cigaal", "Shidaal", "5789654283");
            Contact DeafultContact4 = new Contact("Xaawo", "Dhagdheer", "5531517496");
            Contact DeafultContact5 = new Contact("Dayax", "Geedi", "5524951260");
            PhoneBook.AddContact(DeafultContact1);
            PhoneBook.AddContact(DeafultContact2);
            PhoneBook.AddContact(DeafultContact3);
            PhoneBook.AddContact(DeafultContact4);
            PhoneBook.AddContact(DeafultContact5);


            while (true)
            {
                Console.WriteLine("Please Choose the operation you want to perform:");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Create New Contact");
                Console.WriteLine("(2) Delete Contact");
                Console.WriteLine("(3) Update Contact ");
                Console.WriteLine("(4) List All Contacts");
                Console.WriteLine("(5) Search Contact﻿");

                
                try
                {
                    int operation_to_be_performed = Convert.ToInt32(Console.ReadLine());
                    if (operation_to_be_performed == 1)
                    {
                        Console.WriteLine("Please enter name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please enter surname: ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Please enter phone number: ");
                        string phonenumber = GetPhoneNumber();
                        Contact newContact = new Contact(name, surname, phonenumber);
                        CreateNewContact.AddNewContact(newContact);
                        Console.WriteLine("*******Contact was Added successfully*********\n");
                    }
                
                
                
                    else if (operation_to_be_performed == 2)
                    {
                        while (true)
                        {
                            Console.WriteLine("Please type the name or surname of the person whose contact will be deletd: ");
                            string contact_to_be_deleted = Console.ReadLine();
                            DeleteContact deleteContact = new();

                            if (deleteContact.DeletePassedContact(contact_to_be_deleted) == "successfull")
                            {
                                Console.WriteLine("The Contact named {0} will be deleted. Do you confirm? (y/n): ", contact_to_be_deleted);

                                if (Console.ReadLine() == "y")
                                {
                                    Console.WriteLine("*******Contact was removed successfully*********\n");
                                    break;
                                }
                                else
                                    break;
                            

                            }
                            else
                            {
                                Console.WriteLine("Sorry! We could not find any contact matching your query.");
                                Console.WriteLine("Please Choose operation to perform\n*********************************************\n " +
                                                  "(1)To go back to the main menu: \n(2) To Try again: ");
                                if (Convert.ToInt32(Console.ReadLine()) == 1)
                                    break;
                                else
                                    continue;
                            }
                        }
                    }
                
                
                
                    else if (operation_to_be_performed == 3)
                    {
                        while (true)
                        {
                            Console.WriteLine("Please type the name or surname of the person whose contact will be updated: ");
                            string contact_to_be_updated = Console.ReadLine();

                            Console.WriteLine("Please enter updated name: ");
                            string updatedName = Console.ReadLine();
                            Console.WriteLine("Please enter updated surname: ");
                            string updatedNurname = Console.ReadLine();
                            Console.WriteLine("Please enter updated phone number: ");
                            string updatedPhonenumber = GetPhoneNumber();
                            Contact updatedContact = new Contact(updatedName, updatedNurname, updatedPhonenumber);

                            UpdateContact updateContact = new();
                            if (updateContact.UpdatePassedContact(contact_to_be_updated, updatedContact) == "successfull")
                            {
                                Console.WriteLine("The Contact named {0} will be updated. Do you confirm? (y/n): ", contact_to_be_updated);
                                if (Console.ReadLine() == "y")
                                {
                                    Console.WriteLine("*******Contact was updated successfully*********\n");
                                    break;
                                }
                                else
                                    break;
                            }
                            else
                            {
                                Console.WriteLine("Sorry! We could not find any contact matching your query.");
                                Console.WriteLine("Please Choose operation to perform\n*********************************************\n " +
                                                  "(1)To go back to the main menu: \n(2) To Try again: ");
                                if (Convert.ToInt32(Console.ReadLine()) == 1)
                                    break;
                                else
                                    continue;
                            }
                        }
                    }
                
                
                
                    else if (operation_to_be_performed == 4)
                    {
                        Console.WriteLine("Telephone Directory");
                        Console.WriteLine("**********************************************");
                        ShowContacts showContacts = new ShowContacts();
                    }
                
                
                
                    else
                    {
                        Console.WriteLine("Please Choose the search type you want to perform.");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine("(1) To Search by name or surname:");
                        Console.WriteLine("(2) To Search by phone number:");

                        int search_type = Convert.ToInt32(Console.ReadLine());
                        SearchContact searchContact = new();

                        if (search_type==1)
                        {
                            Console.WriteLine("Please type name or surname to be searched: ");
                            string searchNameOrSurname = Console.ReadLine();
                            SearchContact.SearchByNameOrSurname(searchNameOrSurname);
                        }
                        else
                        {
                            Console.WriteLine("Please type number to be searched: ");
                            string searchNumber = GetPhoneNumber();
                            SearchContact.SearchByNumber(searchNumber);
                        }
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message+" Please Choose a number from 1 to 5.\n");
                    continue;
                }

            }


        }

        private static string GetPhoneNumber()
        {
            while (true)
            {
                
                string input_string_phone_number = Console.ReadLine();

                if (long.TryParse(input_string_phone_number, out long result)&&
                    input_string_phone_number.Length==10&&
                    input_string_phone_number.Substring(0,1)=="5")
                {
                    string phone_number = input_string_phone_number;
                    return phone_number;
                }

                else
                {
                    Console.WriteLine("Incorrect Format! \nPlease enter a 10-digits long number starting with 5 : ");
                    continue;
                }
            }
            
            

        }
    }
}
