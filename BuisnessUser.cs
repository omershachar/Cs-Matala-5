using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5.Utilities;

namespace Assignment5
{
    public class BusinessUser : RegisteredUser
    {
        //Attributes
        string instagram_link;
        List<PopupEvent> popupEvents = new List<PopupEvent>();

        //Properties
        public string Instagram_link
        {
            get => instagram_link;
            set => instagram_link = (string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("Invalid Instagram link.");
        }

        //Constructors
        public BusinessUser() : base()
        {
            Instagram_link = "https://instagram.com/default";
        }

        public BusinessUser(string instagramLink, string password, string email, string userId, string firstName, string lastName, string nickName, string phoneNumber, DateTime birthDate)
            : base(password, email, userId, firstName, lastName, nickName, phoneNumber, birthDate)
        {
            Instagram_link = instagramLink;
        }

        //Methods
        public void AddPopupEvent(PopupEvent popupEvent)
        {
            if (popupEvent != null)
            {
                popupEvents.Add(popupEvent);
            }
            else
            {
                throw new ArgumentNullException("Popup event cannot be null.");
            }
        }

        public void RemovePopupEvent(PopupEvent popupEvent)
        {
            if (popupEvents.Contains(popupEvent))
            {
                popupEvents.Remove(popupEvent);
            }
            else
            {
                throw new ArgumentException("Popup event not found.");
            }
        }

        public void PrintPopupEvents()
        {
            if (popupEvents.Count > 0)
            {
                Console.WriteLine("Popup Events:");
                foreach (var popupEvent in popupEvents)
                {
                    popupEvent.PrintEventDetails();
                }
            }
            else
            {
                Console.WriteLine("No popup events found.");
            }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Instagram Link: {Instagram_link}");
            PrintPopupEvents();
        }
    }
}