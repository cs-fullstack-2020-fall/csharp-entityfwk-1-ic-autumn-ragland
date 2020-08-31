namespace EFIntroductionMVC.Models
{
    // Model used in database
    public class HousePartyInvitee
    {
        public int id {get;set;}
        public string name {get;set;}
        public bool isAttending {get;set;}
        public int numberOfPartiesAttended {get;set;}
        public int age {get;set;}
    }
}