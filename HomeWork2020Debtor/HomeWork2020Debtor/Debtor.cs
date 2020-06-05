using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2020Debtor
{
    class Debtor
    {
        public Debtor(string fullname, DateTime birthDay, string phone, string email, string address, int debt)
        {
            (FullName, BirthDay, Phone, Email, Address, Debt) = (fullname, birthDay, phone, email, address, debt);
        }

        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Debt { get; set; }
        public override string ToString()
        {
            return $"{FullName} {BirthDay.ToShortDateString()} {Phone} {Email} {Address} {Debt}";
        }
    }
}
