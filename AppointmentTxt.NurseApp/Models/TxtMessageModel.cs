using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppointmentTxt.NurseApp.Models
{
    //https://www.twilio.com/docs/api/twiml/sms/twilio_request
    public class TxtMessageModel
    {
        public string SmsSid { get; set; } //A 34 character unique identifier for the message. May be used to later retrieve this message from the REST API.
        public string AccountSid { get; set; } //The 34 character id of the Account this message is associated with.
        public string From { get; set; } //The phone number that sent this message.
        public string To { get; set; } //The phone number of the recipient.
        public string Body { get; set; } //The text body of the SMS message. Up to 160 characters long.

        //Optional
        public string FromCity { get; set; } //The city of the sender
        public string FromState { get; set; } //The state or province of the sender.
        public string FromZip { get; set; } //	The postal code of the called sender.
        public string FromCountry { get; set; } //	The country of the called sender.
        public string ToCity { get; set; } //	The city of the recipient.
        public string ToState { get; set; } //The state or province of the recipient.
        public string ToZip { get; set; } //	The postal code of the recipient.
        public string ToCountry { get; set; } //The country of the recipient.
    }
}