// See https://aka.ms/new-console-template for more information
using HospitalRevamped;
using HospitalRevamped.Models;
using HospitalRevamped.Enums;

Console.WriteLine("Hello, World!");
//var helper = new FluentNHibernateHelper();
//helper.OpenSession();
Hospital Stmartins = new Hospital("Stmartins ", " stadium road");
Receptionist Edem = new Receptionist("edem", "etok", Gender.Female, Stmartins);
Patients nee= new Patients("e","n",Gender.Male,Stmartins,true);
Edem.CheckStatus(nee);
