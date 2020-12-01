using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class PhoneBook
    {
        private List<Contact> contacts;

        public PhoneBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(string firtName,string lastName,List<Phone> telnumbers)
        {
            contacts.Add(new Contact(firtName, lastName, telnumbers));
        }

        public List<Contact> find(string info)
        {
            List<Contact> outputList = new List<Contact>();
            for(int i=0;i<contacts.Count;i++)
            {
                if (contacts[i].FirstName != null && contacts[i].FirstName.Contains(info) || contacts[i].LastName != null && contacts[i].LastName.Contains(info) )
                {
                    outputList.Add(new Contact(contacts[i].FirstName, contacts[i].LastName, contacts[i].TelNumbers));
                }
                else
                {
                    if (contacts[i].TelNumbers != null)
                        for (int j = 0; j < contacts[i].TelNumbers.Count; j++)
                            if (contacts[i].TelNumbers[j].number.Contains(info))
                            {
                                outputList.Add(new Contact(contacts[i].FirstName, contacts[i].LastName, contacts[i].TelNumbers));
                                break;
                            }
                                
                }
            }
            return outputList;
        }
        public void RemoveContact(string info)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName != null ? contacts[i].FirstName.Contains(info) : false || contacts[i].LastName != null ? contacts[i].LastName.Contains(info) : false)
                {
                    contacts.RemoveAt(i);
                    return;
                }
                else
                {
                    if (contacts[i].TelNumbers != null)
                        for (int j = 0; j < contacts[i].TelNumbers.Count; j++)
                            if (contacts[i].TelNumbers[j].number.Contains(info))
                            {
                                contacts.RemoveAt(i);
                                return;
                            }
                }
            }
            
        }

        public List<Contact> getAllContacts()
        {
            List<Contact> outputList = new List<Contact>();
            for (int i = 0; i < contacts.Count; i++)
            {
                outputList.Add(new Contact(contacts[i].FirstName, contacts[i].LastName, contacts[i].TelNumbers));
            }
            return outputList;
        }

        public void edit(int index, Contact changedContact)
        {
            if (index < contacts.Count)
            {
                contacts[index] = new Contact(changedContact.FirstName, changedContact.LastName, changedContact.TelNumbers);
            }
            else
                return; 
        }
    }
}
