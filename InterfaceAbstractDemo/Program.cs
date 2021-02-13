﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concreate;
using System;

namespace InterfaceAbstractDemo.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            //Kimlik bilgileri
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1999,8,11), FirstName="Emrehan",LastName="Aydın", NationalityId =" olmbakgit! :) " });
            // me :)
            Console.ReadLine();
        }
    }
}
