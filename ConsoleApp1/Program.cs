
using Business.Concrete;
using Entitites.Concrete;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;


Person person = new Person();
person.ID = 12345678910;
person.FirstName = "KELAMİ BATUHAN";
person.LastName = "BÖLÜKBAŞI";
person.DateOfBirthYear = 2004;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask((person));
