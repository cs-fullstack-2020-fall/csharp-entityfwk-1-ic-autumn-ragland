using System;
using Microsoft.AspNetCore.Mvc;
using EFIntroductionMVC.Models;
using EFIntroductionMVC.Doa;
using System.Collections.Generic;
using System.Linq;

namespace EFIntroductionMVC.Controllers
{
    public class HouseParty : Controller
    {
        // create reference to database context
        private readonly InviteeContext _context;
        // define database context in constructor
        public HouseParty(InviteeContext context)
        {
            _context = context;
        }
        // landing page to display all invitees in the database
        public IActionResult Index()
        {
            string dispayStr = ""; // string to build
            List<HousePartyInvitee> invitees = _context.invitees.ToList(); // cast database items to list
            // iterate through items in database to display properties for each
            invitees.ForEach(invitee => dispayStr += $"ID : {invitee.id}\nName : {invitee.name}\nIs Attending : {invitee.isAttending}\nNumber of Parties Attended : {invitee.numberOfPartiesAttended}\nAge : {invitee.age}\n");
            // display return string in browser
            return Content(dispayStr);
        }
        [HttpPost] // post method CREATE : info sent in body of request
        public IActionResult AddInvitee(string name, bool isAttending, int numberOfParties, int age)
        {
            // create new invitee object
            HousePartyInvitee invitee = new HousePartyInvitee(){name = name, isAttending = isAttending, numberOfPartiesAttended = numberOfParties, age = age};
            // add new invitee object to database
            _context.Add(invitee);
            // save changes (addition) made to database
            _context.SaveChanges();
            // display confirmation message
            return Content($"Added Invitee : {name}");
        }
        [HttpPut] // put method UPDATE : info sent in body of request
        public IActionResult UpdateInvitee(int id,string name, bool isAttending, int numberOfParties, int age)
        {
            // use LINQ to find item from database by ID
            HousePartyInvitee matchingInvitee = _context.invitees.FirstOrDefault(guest => guest.id == id);
            // update properties
            matchingInvitee.name = name;
            matchingInvitee.isAttending = isAttending;
            matchingInvitee.numberOfPartiesAttended = numberOfParties;
            matchingInvitee.age = age;
            // save changes(update) made to database
            _context.SaveChanges();
            // display confirmation message
            return Content($"Updated Invitee : {id}");
        }
        [HttpDelete] // delete method DELETE : info sent in body of request
        public IActionResult DeleteInvitee(int id)
        {
            // use LINQ to find item from database by ID
            HousePartyInvitee matchingInvitee = _context.invitees.FirstOrDefault(guest => guest.id == id);
            // remove items form database
            _context.Remove(matchingInvitee);
            // save changes(deletion) made to database
            _context.SaveChanges();
            // display confirmation message
            return Content($"Delete Invitee : {id}");
        }
    }
}